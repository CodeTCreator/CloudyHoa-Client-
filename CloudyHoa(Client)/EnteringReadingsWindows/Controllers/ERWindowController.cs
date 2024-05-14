using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using DevExpress.XtraBars.Objects;
using System;
using System.Data;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.EnteringReadingsWindows.Controllers
{
    internal class ERWindowController
    {

        public ERWindowController() { } 

        public void SetCurrentDate(DateTime date, ERDataStructure eRDataStructure)
        {
            eRDataStructure.CurrentDate = date;
        }
        public DateTime GetDate(ERDataStructure eRDataStructure)
        {
            return eRDataStructure.CurrentDate;
        }


        public DataTable GetMainObjectsTable(ERDataStructure eRDataStructure)
        {
            return eRDataStructure.MainObjectsTable;
        }
        public DataTable GetChildObjectsTable(ERDataStructure eRDataStructure)
        {
            return eRDataStructure.ChildTypesObjectsTable;
        }
        public DataTable GetServicesTable(ERDataStructure eRDataStructure)
        {
            return eRDataStructure.ServicesTable;
        }

        public async Task LoadMainObjectsAsync(IDataService dataService, IDataStructure dataStructure)
        {
            if (dataService.GetType() == typeof(ObjectDataService) & dataStructure.GetType() == typeof(ERDataStructure))
            {
                int objectId = -1;
                DataTable allObjects = await ((ObjectDataService)dataService).GetAllObjectsAsync(UserContext.Instance.CurrentUser.hoaId);
                DataTable resultTable = allObjects.Clone();
                Parallel.ForEach(allObjects.AsEnumerable(), row =>
                {
                    objectId = (int)row["id"];

                    DataTable intermediateTable = ((ObjectDataService)dataService).GetPathObject(objectId);
                    string resultName = intermediateTable.AsEnumerable()
                                                .Select(row1 => row1.Field<string>("name"))
                                                .Aggregate((current, next) => current + ", " + next);
                    row["name"] = resultName;
                    // Добавляем обработанную строку в результат
                    lock (resultTable) // Блокировка для безопасного доступа к таблице
                    {
                        resultTable.Rows.Add(row.ItemArray);
                    }
                });
                var sortedRows = resultTable.AsEnumerable()
                                  .OrderBy(row => row.Field<string>("Name"));
                resultTable = sortedRows.CopyToDataTable();
                ((ERDataStructure)dataStructure).MainObjectsTable = resultTable;
            }
        }

        public async Task LoadChildsTypesAsync(IDataService dataService, IDataStructure dataStructure, int typeObject)
        {
            if (dataService.GetType() == typeof(ObjectDataService) & dataStructure.GetType() == typeof(ERDataStructure))
            {
                DataTable childTypes = await((ObjectDataService)dataService).GetTypesOfChildsAsync(typeObject);
                childTypes.Rows.Add(typeObject);
                ((ERDataStructure)dataStructure).ChildTypesObjectsTable = childTypes;
            }
        }

        public async Task LoadChildsObjectsAsync(IDataService dataService, IDataStructure dataStructure,int objectId, int typeObject)
        {
            if (dataService.GetType() == typeof(ObjectDataService) & dataStructure.GetType() == typeof(ObjectDataStructure))
            {
                DataTable childObjects = await ((ObjectDataService)dataService).GetAllChilds(objectId,typeObject);
                ((ObjectDataStructure)dataStructure).DataTable = childObjects;
            }
        }

        public int GetTypeObject( ERDataStructure structure,ObjectDataStructure objectDataStructure)
        {
            var result = structure.MainObjectsTable.Select("id =" + objectDataStructure.FocusedObject.objectId);
            return result.FirstOrDefault() != null ? (int)result.FirstOrDefault()["id1"] : -1;
        }

        public async Task LoadServicesAsync(IDataService dataService, IDataStructure dataStructure, int typeObject)
        {
            if (dataService.GetType() == typeof(MetadataDataService) & dataStructure.GetType() == typeof(ERDataStructure))
            {
                DataTable childObjects = await ((MetadataDataService)dataService).GetServicesAsync(typeObject);
                ((ERDataStructure)dataStructure).ServicesTable = childObjects;
            }
        }

        public async Task LoadOldDynamicParams(IDataService dataService, IDataStructure dataStructure,int objectId, int typeObject)
        {
            if (dataService.GetType() == typeof(DynamicParamsDataService) & dataStructure.GetType() == typeof(DPsDataStructure))
            {
                DataTable oldDynamicParamsTable = await ((DynamicParamsDataService)dataService).GetDPTableFromChildren(objectId,typeObject);
                ((DPsDataStructure)dataStructure).OldDynamicParams = oldDynamicParamsTable;
            }
        }

        private int CheckInTable(DataRow dataRow, DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["property_id"].Equals(dataRow["property_id"])  &
                    row["object_id"].Equals(dataRow["object_id"]))
                {
                    return dataTable.Rows.IndexOf(row);
                }
            }
            return -1;
        }
        /// <summary>
        /// Проверяет есть ли строка в таблице введенных данных; Если да - обновляется строка
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="dataTable"></param>
        public void AddOrUpdateDP(DataRow dataRow, DataTable dataTable)
        {
            int pos = CheckInTable(dataRow, dataTable);
            if(pos == -1)
            {
                dataTable.Rows.Add(dataRow.ItemArray);
            }
            else
            {
                dataTable.Rows[pos]["curr_value"] = dataRow["curr_value"];
                dataTable.Rows[pos]["curr_period"] = dataRow["curr_period"];
            }
        }

        /// <summary>
        /// Проверяет есть ли строка в таблице введенных данных; Если да - удаляется строка
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="dataTable"></param>
        public void CheckAndDeleteEnteringRow(DataRow dataRow, DataTable dataTable)
        {
            int pos = CheckInTable(dataRow, dataTable);
            if (pos != -1)
            {
                dataTable.Rows.RemoveAt(pos);
            }
        }

        /// <summary>
        /// Возвращает true, если все нормально, false если предыдущее значение больше текущего
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns>
        /// </returns>
        public bool CheckCurrentValue(DataRow dataRow)
        {
            if (dataRow["value"].GetType() != typeof(System.DBNull))
            {
                if (float.Parse(dataRow["curr_value"].ToString()) >= float.Parse(dataRow["value"].ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Возвращает true, если все нормально, false если дата предыдущего показания меньше предыдущей
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        public bool CheckCurrentDate(DataRow dataRow)
        {
            if(dataRow["period"].GetType() != typeof(System.DBNull))
            {
                if (DateTime.Parse(dataRow["curr_period"].ToString()) >= DateTime.Parse(dataRow["period"].ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
            
        }

        public void AddER(float value,DateTime period,int propertyId, int personal_account_id, DynamicParamsDataService dynamicParamsDataService)
        {
            dynamicParamsDataService.AddDynamicParam(value, period, propertyId, personal_account_id);
        }

        public void AddERs(DataTable dataTable, DynamicParamsDataService dynamicParamsDataService)
        {
            foreach(DataRow row in dataTable.Rows)
            {
                AddER(float.Parse(row["curr_value"].ToString()),
                    DateTime.Parse(row["curr_period"].ToString()), (int)row["property_id"], (int)row["personal_account_id"], dynamicParamsDataService);
            }
            
        }

        public void CheckAndLoadEnteringData(DataTable checkingTable, DataTable mainTable)
        {
            int rowPos = -1;
            foreach (DataRow row in checkingTable.Rows)
            {
                rowPos = CheckInTable(row, mainTable);
                if (rowPos != -1)
                {
                    row["curr_value"] = mainTable.Rows[rowPos]["curr_value"];
                    row["curr_period"] = mainTable.Rows[rowPos]["curr_period"];
                }
            }
        }

        /// <summary>
        /// Проверка на несоответствие введенных и старых показателей
        /// </summary>
        /// <param name="checkingTable"></param>
        /// <returns></returns>
        public bool CheckEnteringDataValue(DataTable checkingTable)
        {
            foreach (DataRow row in checkingTable.Rows)
            {
               if(row["curr_value"].GetType() != typeof(System.DBNull))
                {
                    if (row["value"].GetType() != typeof(System.DBNull))
                    {
                        if (float.Parse(row["curr_value"].ToString()) < float.Parse(row["value"].ToString()))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Проверка на несоответствие дат показаний
        /// </summary>
        /// <param name="checkingTable"></param>
        /// <returns></returns>
        public bool CheckEnteringDataDate(DataTable checkingTable)
        {
            foreach (DataRow row in checkingTable.Rows)
            {
                if (row["curr_period"].GetType() != typeof(System.DBNull))
                {
                    if(row["period"].GetType() != typeof(System.DBNull))
                    {
                        if (DateTime.Parse(row["curr_period"].ToString()) < DateTime.Parse(row["period"].ToString()))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Проверка есть ли строки в таблице
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public bool CheckTableRows(DataTable dataTable)
        {
            return dataTable.Rows.Count > 0;
        }

    }
}
