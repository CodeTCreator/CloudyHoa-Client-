using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.EHWindows.Controllers;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.MDWindows.Controllers;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using CloudyHoa_Client_.ObjectWindows.MW.Controllers.Service_Controller;
using CloudyHoa_Client_.PersonalAccountsWindows.Controllers;
using CloudyHoa_Client_.SaveExecuteControl;
using DevExpress.DirectX.Common.Direct2D;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraRichEdit.Layout;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.EHWindows
{
    public partial class EHWindow : Form, ISafeExecuteControl
    {

        PADataStructure _paDataStructure;
        PADataService _paDataService;
        ObjectDataStructure _objectDataStructure;
        ObjectDataService _objectDataService;
        EHDataStructure _structure;
        EHDataService _service;
        EHWindowController _controller;
        PAWindowController _paWindowController;
        MetadataDataService _metadataDataService { get; set; }

        public Control ContainerForLoading => this;

        public Control LockControl => panelControlMain;

        public EHWindow()
        {
            InitializeComponent();
        }

        private async void gridControlPA_Click(object sender, EventArgs e)
        {
            if (gridViewPA.GetFocusedRowCellValue("id") != null)
            {
                _paDataStructure.FocusedPA.paId = (int)gridViewPA.GetFocusedRowCellValue("id");
                _paDataStructure.FocusedPA.resposibleId = (int)gridViewPA.GetFocusedRowCellValue("owner_id");
                _paDataStructure.FocusedPA.Account = gridViewPA.GetFocusedRowCellValue("account").ToString();

                _paDataStructure.FocusedPA.Registered = (int)gridViewPA.GetFocusedRowCellValue("registered");
                _paDataStructure.FocusedPA.Lives = (int)gridViewPA.GetFocusedRowCellValue("lives");
                _paDataStructure.FocusedPA.objectId = (int)gridViewPA.GetFocusedRowCellValue("object_id");

                await LoadEnteringHistoryPA();
                BindingEnteringHistory(_structure.EnteringTable);
            }
        }

        private void BindingData()
        {
            BindingObjectTable();
            BindingPATable();
        }
        private void BindingObjectTable()
        {
            treeListControl1.BindingData(_controller.GetObjectsTable(_objectDataStructure));
        }
        private void BindingPATable()
        {
            gridControlPA.DataSource = _paWindowController.GetPATable(_paDataStructure);
        }
        private async void EHWindow_Load(object sender, EventArgs e)
        {
            _controller = new EHWindowController();
            _structure = new EHDataStructure();
            _objectDataStructure = new ObjectDataStructure();
            _objectDataService = new ObjectDataService();
            _paDataStructure = new PADataStructure();
            _paDataService = new PADataService();
            _service = new EHDataService();
            _paWindowController = new PAWindowController();
            _metadataDataService = new MetadataDataService();


            treeListControl1.TreeClick += objectControl_Click;
            await LoadData();

            BindingData();
        }
        private async void objectControl_Click()
        {
            FocusedObject focusedObject = treeListControl1.GetFocusedObject();
            if(_objectDataStructure.FocusedObject.typeObject != focusedObject.typeObject)
            {
                _objectDataStructure.FocusedObject = focusedObject;
                await LoadServices();
                BindingComboBoxServices(_controller.GetServicesTable(_structure));
            }
            else
            {
                _objectDataStructure.FocusedObject = focusedObject;
            }
           

            await LoadPATable();
            BindingPATable();

           
            await LoadEnteringHistoryObject();
            BindingEnteringHistory(_structure.EnteringTable);
        }
        private async Task LoadData()
        {
            await LoadObjectsTable();
        }
        private async Task LoadObjectsTable()
        {
            await GeneralLoadData.LoadData(this, _controller.LoadObjectsTableAsync, _objectDataStructure, _objectDataService);
        }
        private void BindingEnteringHistory(DataTable table)
        {
            gridControlEH.DataSource = table;
        }
        private async Task LoadEnteringHistoryObject()
        {
            await GeneralLoadData.LoadData(this, _controller.LoadEnteringHistoryObjectAsync, _structure, _service, 
                _objectDataStructure.FocusedObject.objectId, _structure.CurrentDate);
        }
        private async Task LoadEnteringHistoryPA()
        {
            await GeneralLoadData.LoadData(this, _controller.LoadEnteringHistoryPAAsync, _structure, _service, 
                _paDataStructure.FocusedPA.paId, _structure.CurrentDate);
        }


        private async Task LoadPATable()
        {
            await this.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    await _paWindowController.LoadPAsTableAsync(_paDataService, _paDataStructure, _objectDataStructure.FocusedObject);

                }
                catch (Exception e)
                {
                    const string caption = "Подключение к серверу";
                    var result = MessageBox.Show(e.Message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }, "Ошибка подключения к северу.");
        }

        private async void comboBoxServices_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // необходимо загружать услуги, показания которых вводятся
            _controller.SetSelectedProp(_structure, (int)comboBoxServices.SelectedValue);
            clearServicesButton.Enabled = true;
            SetServiceFilter();
            BindingEnteringHistory(_controller.GetTemporaryEnteringTable(_structure));
        }
        private void SetServiceFilter()
        {
            if (_structure.CurrentService != -1)
            {
                DataRow[] results = _structure.EnteringTable.Select("property_id =" + _structure.CurrentService);
                if (results.Length > 0)
                {
                    _structure.TemporaryEnteringTable = results.CopyToDataTable();
                }
                else
                {
                    _structure.TemporaryEnteringTable.Clear();
                }
            }
        }

        private void clearServicesButton_Click(object sender, EventArgs e)
        {
            comboBoxServices.SelectedValue = -1;
            clearServicesButton.Enabled = false;
            UpdateTemplateEnteringTable();
            BindingEnteringHistory(_controller.GetTemporaryEnteringTable(_structure));
        }
        private void UpdateTemplateEnteringTable()
        {
            _controller.SetTemporaryEnteringTable(_structure, _controller.GetEnteringTable(_structure));
        }
        private async Task LoadServices()
        {
            await GeneralLoadData.LoadData(this, _controller.LoadCalculationServicesAsync, _structure, _metadataDataService, _objectDataStructure.FocusedObject.typeObject);
        }
        private void BindingComboBoxServices(DataTable dataTable)
        {
            comboBoxServices.DataSource = dataTable;
            comboBoxServices.DisplayMember = "property_name";
            comboBoxServices.ValueMember = "id";
            comboBoxServices.SelectedValue = -1;
        }

        private void dateEditPeriod_EditValueChanged(object sender, EventArgs e)
        {
            _controller.SetSelectedPeriod(_structure, dateEditPeriod.DateTime);
            clearDateButton.Enabled = true;
            SetDateFilter();
            BindingEnteringHistory(_controller.GetTemporaryEnteringTable(_structure));
        }
        private void SetDateFilter()
        {
            if (_structure.CurrentService != -1)
            {
                DataRow[] results = _structure.EnteringTable.Select(
                $"period >= #{_structure.CurrentDate.ToString("yyyy-MM-01")}# AND period " +
                $"< #{_structure.CurrentDate.AddMonths(1).ToString("yyyy-MM-01")}#");
                if (results.Length > 0)
                {
                    _structure.TemporaryEnteringTable = results.CopyToDataTable();
                }
                else
                {
                    _structure.TemporaryEnteringTable.Clear();
                }
            }
        }

        private void clearDate_Click(object sender, EventArgs e)
        {
            _controller.SetSelectedPeriod(_structure, DateTime.MinValue);
            dateEditPeriod.EditValue = null;
            clearDateButton.Enabled = false;
            UpdateTemplateEnteringTable();
            BindingEnteringHistory(_controller.GetTemporaryEnteringTable(_structure));
        }
    }
}
