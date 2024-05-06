using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.MDWindows.Controllers;
using CloudyHoa_Client_.MDWindows.MW;
using CloudyHoa_Client_.MetadataService;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using CloudyHoa_Client_.PersonalAccountsWindows.Controllers;
using CloudyHoa_Client_.SaveExecuteControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.MDWindows
{
    public partial class MDWindow : Form, ISafeExecuteControl
    {
        PADataStructure _paDataStructure;
        PADataService _paDataService;
        ObjectDataStructure _objectDataStructure;
        ObjectDataService _objectDataService;
        MDDataStructure _structure;
        MDWindowController _controller;
        MDDataService _service;
        PAWindowController _paWindowController;


        public Control ContainerForLoading => panelControlMain;

        public Control LockControl => this;

        public MDWindow()
        {
            InitializeComponent();
        }

        private void BindingData()
        {
            BindingObjectTable();
            BindingPATable();
            BindingMDTable();
        }
        private void BindingObjectTable()
        {
            treeListControl1.BindingData(_controller.GetObjectsTable(_objectDataStructure));
        }
        private void BindingPATable()
        {
            gridControlPA.DataSource = _paWindowController.GetPATable(_paDataStructure);
        }
        private void BindingMDTable()
        {
            gridControlMD.DataSource = _controller.GetMDTable(_structure);
        }

        private async Task LoadData()
        {
            await LoadObjectsTable();
        }
        private async Task LoadObjectsTable()
        {
           await GeneralLoadData.LoadData(this,_controller.LoadObjectsTableAsync, _objectDataStructure, _objectDataService);
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
        private async Task LoadMDTableO()
        {
           await GeneralLoadData.LoadData(this, _controller.LoadMDsTableAsyncO, _structure, _service, _objectDataStructure.FocusedObject.objectId);
        }
        private async Task LoadMDTableP()
        {
           await GeneralLoadData.LoadData(this, _controller.LoadMDsTableAsyncP, _structure, _service, _paDataStructure.FocusedPA.paId);
        }

        private async void MDWindow_Load(object sender, EventArgs e)
        {
            _controller = new MDWindowController();
            _structure = new MDDataStructure();
            _objectDataStructure = new ObjectDataStructure();
            _objectDataService = new ObjectDataService();
            _paDataStructure = new PADataStructure();
            _paDataService = new PADataService();
            _paWindowController = new PAWindowController();
            _service = new MDDataService();


            treeListControl1.TreeClick += objectControl_Click;
            await LoadData();

            BindingData();
        }
        private async void objectControl_Click()
        {
            FocusedObject focusedObject = treeListControl1.GetFocusedObject();
            _objectDataStructure.FocusedObject = focusedObject;

            await LoadPATable();
            BindingPATable();
            await LoadMDTableO();
            BindingMDTable();

            addMDButton.Enabled = false;
            editMDButton.Enabled = false;
            deleteMDButton.Enabled = false;
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

                await LoadMDTableP();
                BindingMDTable();

                addMDButton.Enabled = true;
                editMDButton.Enabled = false;
                deleteMDButton.Enabled = false;
            }
        }

        private async void deleteMDButton_Click(object sender, EventArgs e)
        {
            if (gridViewMD.GetFocusedRowCellValue("id") != null)
            {
                int id = (int)gridViewMD.GetFocusedRowCellValue("id");
                _service.DeleteMeteringDevice(id);
                await LoadMDTableO();
                BindingMDTable();
            }
        }

        private void gridControlMD_Click(object sender, EventArgs e)
        {
            if (gridViewMD.GetFocusedRowCellValue("id") != null)
            {
                _structure.FocusedMD.meteringDeviceId = (int)gridViewMD.GetFocusedRowCellValue("id");
                _structure.FocusedMD.number = gridViewMD.GetFocusedRowCellValue("number").ToString();
                _structure.FocusedMD.verificationDate = DateTime.Parse(gridViewMD.GetFocusedRowCellValue("verification_date").ToString());
                _structure.FocusedMD.installationDate = DateTime.Parse(gridViewMD.GetFocusedRowCellValue("installation_date").ToString());
                _structure.FocusedMD.serviceId = (int)gridViewMD.GetFocusedRowCellValue("service_id");
                _structure.FocusedMD.personalAccountId = (int)gridViewMD.GetFocusedRowCellValue("personal_account_id");
                GetPANumber();

                editMDButton.Enabled = true;
                deleteMDButton.Enabled = true;
            }
        }
        private void GetPANumber()
        {
            _paDataStructure.FocusedPA.Account = 
                _paDataStructure.PersonalAccountTable.Select("id = " + _structure.FocusedMD.personalAccountId).First()["account"].ToString();
        }
        private async void addMDButton_Click(object sender, EventArgs e)
        {
            MDMW mDMW = new MDMW(_objectDataStructure.FocusedObject.typeObject,
                _objectDataStructure.FocusedObject.nameType + " " + _objectDataStructure.FocusedObject.identificator,
                _paDataStructure.FocusedPA.Account, _paDataStructure.FocusedPA.paId, _service);
            mDMW.ShowDialog();
            await LoadMDTableO();
            BindingMDTable();
        }

        private async void editMDButton_Click(object sender, EventArgs e)
        {
            
            MDMW mDMW = new MDMW(_objectDataStructure.FocusedObject.typeObject,
                _objectDataStructure.FocusedObject.nameType + " " + _objectDataStructure.FocusedObject.identificator,
                _paDataStructure.FocusedPA.Account, _structure.FocusedMD, _service);
            mDMW.ShowDialog();
            await LoadMDTableO();
            BindingMDTable();
        }
    }
}
