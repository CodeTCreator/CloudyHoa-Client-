using CloudyHoa_Client_.BenefitWindows.Controllers;
using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using CloudyHoa_Client_.PersonalAccountsWindows.Controllers;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.CalculationWindows.Controllers
{
    public class CalculationWindowController
    {

        public CalculationWindowController() { }
        public async Task LoadTypesObjectsTable(IDataService dataService, IDataStructure dataStructure)
        {
            DataTable dataTable = dataService.GetType() == typeof(ObjectDataService) ?
                await ((ObjectDataService)dataService).GetObjectsStructureAsync(UserContext.Instance.CurrentUser.hoaId) : null;
            dataTable.TableName = "TypesObjects";
            if (dataStructure.GetType() == typeof(CalculationDataStructure))
            {
                ((CalculationDataStructure)dataStructure).TypesObjectsTable = dataTable;
            }
        }

        public DataTable GetObjectsTable(ObjectDataStructure objectDataStructure)
        {
            return objectDataStructure.DataTable;
        }
        public void SetObjectsTable(ObjectDataStructure objectDataStructure, DataTable data)
        {
            objectDataStructure.DataTable = data;
        }

        public DataTable GetServicesTable(CalculationDataStructure calculationDataStructure)
        {
            return calculationDataStructure.ServicesTable;
        }
        public void LoadServicesTable(DataTable dataTable, CalculationDataStructure calculationDataStructure)
        {
            calculationDataStructure.ServicesTable = dataTable;
        }
        public DataTable GetTemplate(CalculationDataStructure calculationDataStructure)
        {
            return calculationDataStructure.TemplateTable;
        }
        public void SetTemplatetable(CalculationDataStructure calculationDataStructure, DataTable dataTable)
        {
            calculationDataStructure.TemplateTable = dataTable;
        }
        public DataTable GetCalcuationsTable(CalculationDataStructure calculationDataStructure)
        {
            return calculationDataStructure.CalculationsTable;
        }
        public void LoadCalculationsTable(DataTable dataTable, CalculationDataStructure calculationDataStructure)
        {
            calculationDataStructure.CalculationsTable = dataTable;
        }

        public async Task LoadCalculationServicesAsync(IDataService dataService, IDataStructure dataStructure, int typeObject)
        {
            if (dataService.GetType() == typeof(MetadataDataService) & dataStructure.GetType() == typeof(CalculationDataStructure))
            {
                DataTable childObjects = await ((MetadataDataService)dataService).GetCalculationServices(typeObject);
                ((CalculationDataStructure)dataStructure).ServicesTable = childObjects;
            }
        }

        public async Task LoadTemplateTableAsync(IDataService dataService, IDataStructure dataStructure, int propId, int typeObject)
        {
            if (dataService.GetType() == typeof(CalculationDataService) & dataStructure.GetType() == typeof(CalculationDataStructure))
            {
                DataTable templateTable = await ((CalculationDataService)dataService).GetCalculations(propId, typeObject);
                ((CalculationDataStructure)dataStructure).TemplateTable = templateTable;
            }
        }
        public async Task LoadTariffsForMetadata(IDataService dataService, IDataStructure dataStructure, int propId)
        {
            if (dataService.GetType() == typeof(CalculationDataService) & dataStructure.GetType() == typeof(CalculationDataStructure))
            {
                DataTable templateTable = await ((CalculationDataService)dataService).GetTariffsFromMetadata(propId);
                ((CalculationDataStructure)dataStructure).TariffsTable = templateTable;
            }
        }

        public void CheckAndLoadCalculation(CalculationDataStructure calculationDataStructure)
        {
            int tariff_id = 0;
            int metadata_id = 0;
            int personal_account_id = 0;
            float result_tariff;
            foreach (DataRow dataRow in calculationDataStructure.CalculationsTable.Rows)
            {
                tariff_id = (int)dataRow["tariff_id"];
                metadata_id = (int)dataRow["metadata_id"];
                personal_account_id = (int)dataRow["personal_account_id"];
                int intermediateResult = calculationDataStructure.ResultTable.AsEnumerable().
                    Where(row => row.Field<int>("tariff_id") == tariff_id &
                    row.Field<int>("metadata_id") == metadata_id &
                     row.Field<int>("personal_account_id") == personal_account_id).Count();
                if (intermediateResult != 0)
                {
                    DataRow newRow = calculationDataStructure.ResultTable.AsEnumerable().
                    Where(row => row.Field<int>("tariff_id") == tariff_id &
                    row.Field<int>("metadata_id") == metadata_id &
                     row.Field<int>("personal_account_id") == personal_account_id).CopyToDataTable().Rows[0];
                    dataRow["result_tariff"] = newRow["result_tariff"];
                    dataRow["benefit_value"] = newRow["benefit_value"];
                    dataRow["result_value"] = newRow["result_value"];
                    /*calculationDataStructure.ResultTariffsTable.Rows.Add(dataRow.ItemArray);*/ ////
                }
            }
        }
        public void AddInResultTariffsTable(CalculationDataStructure calculationDataStructure)
        {
            int tariff_id = 0;
            int metadata_id = 0;
            int personal_account_id = 0;
            float result_tariff;
            foreach (DataRow dataRow in calculationDataStructure.TemplateTable.Rows)
            {
                tariff_id = (int)dataRow["tariff_id"];
                metadata_id = (int)dataRow["metadata_id"];
                personal_account_id = (int)dataRow["personal_account_id"];
                int intermediateResult = calculationDataStructure.ResultTariffsTable.AsEnumerable().
                    Where(row => row.Field<int>("tariff_id") == tariff_id &
                    row.Field<int>("metadata_id") == metadata_id &
                     row.Field<int>("personal_account_id") == personal_account_id).Count();
                if (intermediateResult == 0)
                {
                    DataTable newRow = calculationDataStructure.TemplateTable.AsEnumerable().
                    Where(row => row.Field<int>("tariff_id") == tariff_id &
                    row.Field<int>("metadata_id") == metadata_id &
                     row.Field<int>("personal_account_id") == personal_account_id).CopyToDataTable().Copy();
                    newRow.Columns.Remove("result_value");
                    newRow.Columns.Remove("benefit_value");
                    calculationDataStructure.ResultTariffsTable.Rows.Add(newRow.Rows[0].ItemArray);
                }
            }
        }

        public void LoadTariffsResultFromTable(CalculationDataStructure calculationDataStructure)
        {
            if (calculationDataStructure.ResultTariffsTable != null)
            {
                int tariff_id = 0;
                int metadata_id = 0;
                int personal_account_id = 0;
                float result_tariff;
                foreach (DataRow dataRow in calculationDataStructure.TemplateTable.Rows)
                {
                    tariff_id = (int)dataRow["tariff_id"];
                    metadata_id = (int)dataRow["metadata_id"];
                    personal_account_id = (int)dataRow["personal_account_id"];
                    var intermediateResult = calculationDataStructure.ResultTariffsTable.AsEnumerable().
                        Where(row => row.Field<int>("tariff_id") == tariff_id &
                        row.Field<int>("metadata_id") == metadata_id &
                         row.Field<int>("personal_account_id") == personal_account_id).Count();
                    if (intermediateResult != 0)
                    {
                        dataRow["result_tariff"] = calculationDataStructure.ResultTariffsTable.AsEnumerable().
                        Where(row => row.Field<int>("tariff_id") == tariff_id &
                        row.Field<int>("metadata_id") == metadata_id &
                         row.Field<int>("personal_account_id") == personal_account_id).CopyToDataTable().Rows[0]["result_tariff"];
                    }
                }
            }
        }

        public int GetSelectedProp(CalculationDataStructure calculationDataStructure)
        {
            return calculationDataStructure.CurrentService;
        }
        public void SetSelectedProp(CalculationDataStructure calculationDataStructure, int propId)
        {
            calculationDataStructure.CurrentService = propId;
        }
        public DataTable GetResultTariffsTable(CalculationDataStructure calculationDataStructure)
        {
            return calculationDataStructure.ResultTariffsTable;
        }
        public DateTime GetSelectedPeriod(CalculationDataStructure calculationDataStructure)
        {
            return calculationDataStructure.CurrentDate;
        }
        public void SetSelectedPeriod(CalculationDataStructure calculationDataStructure, DateTime period)
        {
            calculationDataStructure.CurrentDate = period;
        }


        public void CreateTariffTable(CalculationDataStructure calculationDataStructure)
        {
            calculationDataStructure.TariffsTable = calculationDataStructure.TemplateTable.Clone() ;
        }
        public void LoadTariffTable(CalculationDataStructure calculationDataStructure)
        {
            calculationDataStructure.TariffsTable = calculationDataStructure.TemplateTable.AsEnumerable().Where(row => row.Field<int>("object_id") == calculationDataStructure.FocusedObject.objectId).CopyToDataTable();
        }
        public void LoadInResultTariffsTable(CalculationDataStructure calculationDataStructure)
        {
            int tariff_id = 0;
            int metadata_id = 0;
            int personal_account_id = 0;
            float result_tariff;
            foreach(DataRow dataRow in calculationDataStructure.TariffsTable.Rows) 
            {
                tariff_id = (int)dataRow["tariff_id"];
                metadata_id = (int)dataRow["metadata_id"];
                personal_account_id = (int)dataRow["personal_account_id"];
                var intermediateResult = calculationDataStructure.ResultTariffsTable.AsEnumerable().
                    Where(row => row.Field<int>("tariff_id") == tariff_id &
                    row.Field<int>("metadata_id") == metadata_id &
                     row.Field<int>("personal_account_id") == personal_account_id).FirstOrDefault();
               if(intermediateResult != null)
               {
                    dataRow["result_tariff"] = intermediateResult["result_tariff"];
               }
            }
        }




        public DataTable GetTariffsTable(CalculationDataStructure calculationDataStructure)
        {
            return calculationDataStructure.TariffsTable;
        }
        public void SetTariffsTable(CalculationDataStructure calculationDataStructure, DataTable dataTable)
        {
            calculationDataStructure.TariffsTable = dataTable;
        }

        public void CalculateTariffResult(DataTable dataTable,CalculationDataStructure calculationDataStructure, CalculationDataService calculationDataService)
        {
            foreach (DataRow dataRow in dataTable.Rows)
            {
                dataRow["result_tariff"] = calculationDataService.CalculateTariffResult((int)dataRow["metadata_id"],
                    (int)dataRow["object_id"], (int)dataRow["personal_account_id"], DateTime.Parse(dataRow["period"].ToString())) ;
                //(float)dataRow["value"] * (float)dataRow["value1"];
            }
        }

        public DataTable GetBenefitsTable(CalculationDataStructure calculationDataStructure)
        {
            return calculationDataStructure.BenefitsTable;
        }

        public void SetBenefitsTable(CalculationDataStructure calculationDataStructure, DataTable dataTable)
        {
            calculationDataStructure.BenefitsTable = dataTable;
        }

        public async Task CalculateValues(CalculationDataStructure calculationDataStructure, CalculationDataService calculationDataService)
        {
            int pa_id;
            DataTable temporaryTable;
            int objectId;
            float accrued_result;
            float temporaryBenefit = 0;
            BenefitDataService benefitDataService = new BenefitDataService();
            // Получить значение расчета

            CalculateTariffResult(calculationDataStructure.TemplateTable, calculationDataStructure, calculationDataService);

            foreach (DataRow dataRow in calculationDataStructure.CalculationsTable.Rows)
            {
                accrued_result = 0;
                pa_id = (int)dataRow["personal_account_id"];
                objectId = (int)dataRow["object_id"];
                temporaryTable = calculationDataStructure.TemplateTable.AsEnumerable().Where(row => 
                row.Field<int>("personal_account_id") == pa_id).CopyToDataTable();
                foreach (DataRow row in temporaryTable.Rows)
                {
                    accrued_result += (float)row["result_tariff"];
                }
                dataRow["result_tariff"] = accrued_result;

                Task<float> floatTask  = CalculateBenefit(calculationDataStructure, benefitDataService, objectId,calculationDataStructure.CurrentService);
                temporaryBenefit = await floatTask;

                dataRow["benefit_value"] = (float)dataRow["result_tariff"] * temporaryBenefit;

                dataRow["result_value"] = (float)dataRow["result_tariff"] - (float)dataRow["benefit_value"];

            }
        }

        public async Task<bool> CheckCalculation(CalculationDataStructure calculationDataStructure, CalculationDataService calculationDataService)
        {
            bool result = false; bool searchResult;
            int propId = GetSelectedProp(calculationDataStructure); 
            DateTime period = GetSelectedPeriod(calculationDataStructure);
            int paId;
            DataTable intermediate = await calculationDataService.GetCalculationsFromMetadata(GetSelectedProp(calculationDataStructure), 
                GetSelectedPeriod(calculationDataStructure));
            foreach (DataRow dataRow in calculationDataStructure.CalculationsTable.Rows)
            {
                paId = (int)dataRow["personal_account_id"];
                var resTable = intermediate.AsEnumerable().Where(row =>
                row.Field<int>("metadata_id") == propId &
                row.Field<DateTime>("period") == period &
                row.Field<int>("pa_id") == paId);
                if (resTable.Count() > 0)
                {
                    dataRow["result_value"] = 
                        resTable.CopyToDataTable().Rows[0]["result_value"];
                }
            }
            return result;
        }


        public void CreateCalculateTable(CalculationDataStructure calculationDataStructure)
        {
            //calculationDataStructure.CalculationsTable = calculationDataStructure.TemplateTable.Clone();
            calculationDataStructure.CalculationsTable = calculationDataStructure.TemplateTable.AsEnumerable().GroupBy(row => row.Field<int>("object_id"))
                                .Select(group => group.First()).Count() > 0 ? calculationDataStructure.TemplateTable.AsEnumerable().GroupBy(row => row.Field<int>("object_id"))
                                .Select(group => group.First()).CopyToDataTable() : new DataTable();
            //calculationDataStructure.CalculationsTable = calculationDataStructure.TemplateTable.Copy();
            //AddColumnsToCalculateTable(calculationDataStructure.CalculationsTable);
        }

        public void AddColumnsToCalculateTable(DataTable dataTable)
        {
            dataTable.Columns.AddRange(
                new[] {
                    new DataColumn("benefit_value", typeof(float)),
                    new DataColumn("result_value", typeof(float))
                });
        }


        public async Task<float> CalculateBenefit(CalculationDataStructure structure,BenefitDataService benefitDataService,int objectId, int metadataId)
        {
            float result = 0;
            await LoadBenefitTable(structure, benefitDataService, objectId, metadataId);
            DataTable dataTable = GetBenefitsTable(structure);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                result += (float)dataRow["value"] * (int)dataRow["quantity"] / 100;
            }
            if (result > 0.5)
            {
                result = 0.5f;
            }
            return result;
            //return 0.5f;
        }

        public async Task LoadBenefitTable(CalculationDataStructure calculationDataStructure, BenefitDataService benefitDataService, int objectId, int metadataId)
        {
            DataTable benefitsTable = await benefitDataService.GetBenefits(objectId,metadataId);
            calculationDataStructure.BenefitsTable = benefitsTable;
        }



        public DataTable GetResultTable(CalculationDataStructure calculationDataStructure)
        {
            return calculationDataStructure.ResultTable;
        }

        public void SetResultTable(CalculationDataStructure calculationDataStructure , DataTable dataTable)
        {
            calculationDataStructure.ResultTable = dataTable;
        }

        public void ReplenishResultTable(CalculationDataStructure calculationDataStructure)
        {
            bool result;
            foreach (DataRow dataRow in calculationDataStructure.CalculationsTable.Rows)
            {
                result = calculationDataStructure.ResultTable != null ?
                    calculationDataStructure.ResultTable.AsEnumerable().Any(row =>
                row.Field<int>("personal_account_id") == (int)dataRow["personal_account_id"] &
                row.Field<int>("metadata_id") == (int)dataRow["metadata_id"]) : false;
                if (!result)
                {
                    calculationDataStructure.ResultTable.Rows.Add(dataRow.ItemArray);
                }
            }
        }


        public async Task LoadPersonalAccounts(IDataService dataService, IDataStructure dataStructure, int typeObject)
        {
            if (dataService.GetType() == typeof(PADataService) & dataStructure.GetType() == typeof(CalculationDataStructure))
            {
                DataTable templateTable = await ((PADataService)dataService).GetPAs(typeObject);
                ((CalculationDataStructure)dataStructure).TemplateTable = templateTable;
            }
        }

        public FocusedObject GetFocusedObject(CalculationDataStructure dataStructure) 
        { 
            return dataStructure.FocusedObject;
        }

        public void CopyStructureForResultTableFromCalc(CalculationDataStructure dataStructure)
        {
            if (dataStructure.ResultTable == null || 
                dataStructure.ResultTable.Columns.Count != dataStructure.CalculationsTable.Columns.Count)
            {
                dataStructure.ResultTable = dataStructure.CalculationsTable.Clone();
            }
        }

        public void CopyStructureForResultTableFromTariff(CalculationDataStructure dataStructure)
        {
            if (dataStructure.ResultTariffsTable == null & dataStructure.TariffsTable != null)
            {
                dataStructure.ResultTariffsTable = dataStructure.TariffsTable.Clone();
            }
        }

        public void SaveCalculation(CalculationDataStructure dataStructure, CalculationDataService calculationDataService)
        {
            int propId;
            DateTime period;
            float value;
            int paId;
            foreach (DataRow row in dataStructure.ResultTable.Rows)
            {
                propId = (int)row["metadata_id"];
                value = (float)row["result_value"];
                paId = (int)row["personal_account_id"];
                period = DateTime.Parse(row["period"].ToString());
                calculationDataService.AddCalculation(propId, period, value, paId);
            }
        }

        public void ClearResultTable(CalculationDataStructure dataStructure)
        {
            dataStructure.ResultTable.Rows.Clear();
            dataStructure.ResultTariffsTable.Rows.Clear();
        }
    }
}