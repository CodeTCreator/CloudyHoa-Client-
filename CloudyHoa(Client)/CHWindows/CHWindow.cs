using CloudyHoa_Client_.CHWindows.Controllers;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.EHWindows.Controllers;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using CloudyHoa_Client_.PersonalAccountsWindows.Controllers;
using CloudyHoa_Client_.SaveExecuteControl;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.CHWindows
{
    public partial class CHWindow : Form, ISafeExecuteControl
    {


        PADataStructure _paDataStructure;
        PADataService _paDataService;
        ObjectDataStructure _objectDataStructure;
        ObjectDataService _objectDataService;
        CHDataStructure _structure;
        CHDataService _service;
        CHWindowController _controller;
        PAWindowController _paWindowController;
        MetadataDataService _metadataDataService { get; set; }
        public CHWindow()
        {
            InitializeComponent();
        }

        public Control ContainerForLoading => this;

        public Control LockControl => panelControlMain;

        private void clearDate_Click(object sender, EventArgs e)
        {
            _controller.SetSelectedPeriod(_structure, DateTime.MinValue);
            dateEditPeriod.EditValue = null;
            clearDateButton.Enabled = false;
            UpdateTemplateCalculatingTable();
            BindingCalculatingHistory(_controller.GetTemporaryCalculatingTable(_structure));
        }
        private void UpdateTemplateCalculatingTable()
        {
            _controller.SetTemporaryCalculatingTable(_structure, _controller.GetCalculatingTable(_structure));
        }
        private void BindingCalculatingHistory(DataTable table)
        {
            gridControlEH.DataSource = table;
        }

        private void dateEditPeriod_EditValueChanged(object sender, EventArgs e)
        {
            _controller.SetSelectedPeriod(_structure, dateEditPeriod.DateTime);
            clearDateButton.Enabled = true;
            SetDateFilter();
            BindingCalculatingHistory(_controller.GetTemporaryCalculatingTable(_structure));
        }
        private void SetDateFilter()
        {
            if (_structure.CurrentService != -1)
            {
                DataRow[] results = _structure.CalculatingTable.Select(
                $"period >= #{_structure.CurrentDate.ToString("yyyy-MM-01")}# AND period " +
                $"< #{_structure.CurrentDate.AddMonths(1).ToString("yyyy-MM-01")}#");
                if (results.Length > 0)
                {
                    _structure.TemporaryCalculatingTable = results.CopyToDataTable();
                }
                else
                {
                    _structure.TemporaryCalculatingTable.Clear();
                }
            }
        }

        private void clearServicesButton_Click(object sender, EventArgs e)
        {
            comboBoxServices.SelectedValue = -1;
            clearServicesButton.Enabled = false;
            UpdateTemplateCalculatingTable();
            BindingCalculatingHistory(_controller.GetTemporaryCalculatingTable(_structure));
        }

        private void comboBoxServices_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // необходимо загружать услуги, показания которых вводятся
            _controller.SetSelectedProp(_structure, (int)comboBoxServices.SelectedValue);
            clearServicesButton.Enabled = true;
            SetServiceFilter();
            BindingCalculatingHistory(_controller.GetTemporaryCalculatingTable(_structure));
        }
        private void SetServiceFilter()
        {
            if (_structure.CurrentService != -1)
            {
                DataRow[] results = _structure.CalculatingTable.Select("property_id =" + _structure.CurrentService);
                if (results.Length > 0)
                {
                    _structure.TemporaryCalculatingTable = results.CopyToDataTable();
                }
                else
                {
                    _structure.TemporaryCalculatingTable.Clear();
                }
            }
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

                await LoadCalculatingHistoryPA();
                BindingCalculatingHistory(_structure.CalculatingTable);
            }
        }
        private async Task LoadCalculatingHistoryPA()
        {
            await GeneralLoadData.LoadData(this, _controller.LoadCalculatingHistoryPAAsync, _structure, _service,
                _paDataStructure.FocusedPA.paId, _structure.CurrentDate);
        }
        private async void CHWindow_Load(object sender, EventArgs e)
        {
            _controller = new CHWindowController();
            _structure = new CHDataStructure();
            _objectDataStructure = new ObjectDataStructure();
            _objectDataService = new ObjectDataService();
            _paDataStructure = new PADataStructure();
            _paDataService = new PADataService();
            _service = new CHDataService();
            _paWindowController = new PAWindowController();
            _metadataDataService = new MetadataDataService();


            treeListControl1.TreeClick += objectControl_Click;
            await LoadData();

            BindingData();
        }
        private async void objectControl_Click()
        {
            FocusedObject focusedObject = treeListControl1.GetFocusedObject();
            if (_objectDataStructure.FocusedObject.typeObject != focusedObject.typeObject)
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
            BindingCalculatingHistory(_structure.CalculatingTable);
        }
        private async Task LoadData()
        {
            await LoadObjectsTable();
        }
        private async Task LoadObjectsTable()
        {
            await GeneralLoadData.LoadData(this, _controller.LoadObjectsTableAsync, _objectDataStructure, _objectDataService);
        }
        private async Task LoadEnteringHistoryObject()
        {
            await GeneralLoadData.LoadData(this, _controller.LoadCalculatingHistoryObjectAsync, _structure, _service,
                _objectDataStructure.FocusedObject.objectId, _structure.CurrentDate);
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
    }
}
