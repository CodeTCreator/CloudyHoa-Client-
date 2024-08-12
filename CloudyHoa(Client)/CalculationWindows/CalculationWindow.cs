using CloudyHoa_Client_.CalculationWindows.Controllers;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using CloudyHoa_Client_.PersonalAccountsWindows.Controllers;
using CloudyHoa_Client_.SaveExecuteControl;
using DevExpress.DirectX.Common.Direct2D;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.CalculationWindows
{
    public partial class CalculationWindow : Form, ISafeExecuteControl
    {
        CalculationWindowController _controller { get; set; }
        ObjectDataService _objectDataService {  get; set; }
        CalculationDataStructure _structure { get; set; }
        MetadataDataService _metadataDataService { get; set; }

        CalculationDataService _dataService { get; set; }

        PADataService _paDataService {  get; set; }

        public Control ContainerForLoading => this;

        public Control LockControl => panelControlMain;

        public CalculationWindow()
        {
            InitializeComponent();
            _objectDataService = new ObjectDataService();
            _controller = new CalculationWindowController();
        }

        private void AddNewColumns(DataTable dataTable)
        {
            if (!dataTable.Columns.Contains("period"))
            {
                dataTable.Columns.AddRange(
                new[] {
                    new DataColumn("period", typeof(DateTime))
                });
                foreach (DataRow row in dataTable.Rows)
                {
                    row["period"] = _structure.CurrentDate;
                }
            }
        }


        public async Task LoadObjects()
        {
            await General.GeneralLoadData.LoadData(this, _controller.LoadTypesObjectsTable, _structure, _objectDataService);
        }
        private async void CalculationWindow_Load(object sender, EventArgs e)
        {
            _structure = new CalculationDataStructure();
            _metadataDataService = new MetadataDataService();
            _objectDataService = new ObjectDataService();
            _controller = new CalculationWindowController();
            _dataService = new CalculationDataService();
            _paDataService = new PADataService();


            await LoadObjects();
            BindingTypesObjectTree();


            await LoadServices();
            BindingComboBoxServices(_controller.GetServicesTable(_structure));

            //await LoadServices();
            //BindingComboBoxServices();

            await GeneralLoadData.LoadData(this, _controller.LoadTemplateTableAsync, _structure,
               _dataService, _controller.GetSelectedProp(_structure), _controller.GetFocusedObject(_structure).typeObject);

            

            AddResultTariffColumn(_controller.GetTemplate(_structure));
            _controller.CreateCalculateTable(_structure);
            _controller.CreateTariffTable(_structure);

            _controller.CopyStructureForResultTableFromCalc(_structure);
            _controller.CopyStructureForResultTableFromTariff(_structure);
        }


        private async Task LoadServices()
        {
           await _controller.LoadCalculationServicesAsync(_metadataDataService, _structure, _structure.FocusedObject.typeObject);
        }

        private void BindingTypesObjectTree()
        {
            
            treeListTO.KeyFieldName = "id";
            treeListTO.ParentFieldName = "parent_type";
            treeListTO.DataSource = _structure.TypesObjectsTable;
        }
        private void BindingComboBoxServices(DataTable dataTable)
        {
            comboBoxServices.DataSource = dataTable;
            comboBoxServices.DisplayMember = "property_name";
            comboBoxServices.ValueMember = "id";
            comboBoxServices.SelectedValue = -1;
        }


        private async void  comboBoxServices_SelectionChangeCommitted(object sender, EventArgs e)
        {

            // необходимо загружать услуги, показания которых вводятся

            _controller.SetSelectedProp(_structure, (int)comboBoxServices.SelectedValue);
            await GeneralLoadData.LoadData(this, _controller.LoadTemplateTableAsync, _structure,
                _dataService, _controller.GetSelectedProp(_structure), _controller.GetFocusedObject(_structure).typeObject);
            AddResultTariffColumn(_controller.GetTemplate(_structure));
            AddNewColumns(_controller.GetTemplate(_structure));
            _controller.AddColumnsToCalculateTable(_controller.GetTemplate(_structure));
            

            _controller.CreateCalculateTable(_structure);

            _controller.CopyStructureForResultTableFromCalc(_structure);
            await _controller.CheckCalculation(_structure, _dataService);
            CheckAndLoadCalculation();


            LoadTariffsResultFromTable();
            BindingCalculationTable(_controller.GetCalcuationsTable(_structure));
        }


        private void CheckAndLoadCalculation()
        {
            _controller.CheckAndLoadCalculation(_structure);
        }
        private void LoadTariffsResultFromTable()
        {
            _controller.LoadTariffsResultFromTable(_structure);
        }
        private void BindingCalculationTable(DataTable dataTable)
        {
            gridControlCalculation.DataSource = dataTable; 
        }

        private async void treeListTO_Click(object sender, EventArgs e)
        {
            if (treeListTO.GetFocusedRowCellValue("id") != null)
            {
                _structure.FocusedObject.typeObject = (int)treeListTO.GetFocusedRowCellValue("id");
            }
            await LoadServices();
            BindingComboBoxServices(_controller.GetServicesTable(_structure));
            BindingCalculationTable(null);
        }

        private void dateEditPeriod_EditValueChanged(object sender, EventArgs e)
        {
            clearServicesButton.Enabled = true;
            gridControlCalculation.Enabled = true;
            gridControlTarrif.Enabled = true;   
            comboBoxServices.Enabled = true;
            calculateButton.Enabled = true;
            saveButton.Enabled = true;
            _controller.SetSelectedPeriod(_structure, dateEditPeriod.DateTime);
        }

        private void clearServicesButton_Click(object sender, EventArgs e)
        {
            comboBoxServices.SelectedValue = -1;
        }

        private async void gridControlCalculation_Click(object sender, EventArgs e)
        {
            
            if (gridView1.GetFocusedRowCellValue("personal_account_id") != null)
            {
                _structure.FocusedObject.objectId = (int)gridView1.GetFocusedRowCellValue("object_id");


                await GeneralLoadData.LoadData(this, _controller.LoadTariffsForMetadata, _structure,
                _dataService, _controller.GetSelectedProp(_structure));

                _controller.LoadTariffTable(_structure);

                _controller.LoadInResultTariffsTable(_structure);

                //AddResultTariffColumn(_controller.GetTariffsTable(_structure));
                BindingTariffsTable();
            }
        }

        private void BindingTariffsTable()
        {
            gridControlTarrif.DataSource = _controller.GetTariffsTable(_structure);
        }

        private void AddResultTariffColumn(DataTable dataTable)
        {
            dataTable.Columns.AddRange(
                new[] {
                    new DataColumn("result_tariff", typeof(float))
                });
        }

        private async void calculateButton_Click(object sender, EventArgs e)
        {
            
            await _controller.CalculateValues(_structure,_dataService);
            //BindingCalculationTable(_controller.GetCalcuationsTable(_structure));

             AddNewColumns(_controller.GetResultTariffsTable(_structure));
;            _controller.AddInResultTariffsTable(_structure);
            

            _controller.ReplenishResultTable(_structure);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _controller.SaveCalculation(_structure, _dataService);
            _controller.ClearResultTable(_structure);
        }
    }
}
