using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using CloudyHoa_Client_.PersonalAccountsWindows.Controllers;
using CloudyHoa_Client_.PersonalAccountsWindows.MW;
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

namespace CloudyHoa_Client_.PersonalAccountsWindows
{
    public partial class PAWindow : Form, ISafeExecuteControl
    {
        PADataService _paDataService;
        PADataStructure _structure;
        PAWindowController _controller;
        ObjectDataStructure _objectDataStructure;
        ObjectDataService _objectDataService;

        public Control ContainerForLoading => this;
        public Control LockControl => panelControl;

        public PAWindow()
        {
            InitializeComponent();
        }

        private async void PAWindow_Load(object sender, System.EventArgs e)
        {
            _controller = new PAWindowController();
            _paDataService = new PADataService();
            _structure = new PADataStructure();   
            _objectDataStructure   = new ObjectDataStructure();
            _objectDataService = new ObjectDataService();

            treeListControl1.TreeClick += objectControl_Click;
            await LoadData();
            BindingData();
        }

        private void BindingData()
        {
            BindingObjectsTable();
            BindingPAsTable();
        }
        private void BindingObjectsTable()
        {
            treeListControl1.BindingData(_objectDataStructure.DataTable);
        }
        private void BindingPAsTable()
        {
            gridControlPA.DataSource = _structure.PersonalAccountTable;
        }
        private async void objectControl_Click()
        {
            FocusedObject focusedObject = treeListControl1.GetFocusedObject();
            _objectDataStructure.FocusedObject = focusedObject;
            if (focusedObject.objectId != -1)
            {
                addAccountButton.Enabled = true;
            }
            else
            {
                addAccountButton.Enabled = false;
            }
            await UpdatePAsTable();
        }
        private async Task LoadData()
        {
            await this.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    //await Task.Run(() =>
                    //{
                    await _controller.LoadObjectsTableAsync(_objectDataService, _objectDataStructure);
                    //});
                }
                catch (Exception e)
                {
                    const string caption = "Подключение к серверу";
                    var result = MessageBox.Show(e.InnerException.Message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }, "Ошибка подключения к северу.");
        }
        private async Task LoadPAsData()
        {
            await this.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    //await Task.Run(() =>
                    //{
                    await _controller.LoadPAsTableAsync(_paDataService, _structure,
                        _objectDataStructure.FocusedObject);
                    //});
                }
                catch (Exception e)
                {
                    const string caption = "Подключение к серверу";
                    var result = MessageBox.Show(e.InnerException.Message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }, "Ошибка подключения к северу.");
        }

        private async Task UpdatePAsTable()
        {
            await LoadPAsData();
            BindingPAsTable();
        }

        private void gridControlPA_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("id") != null)
            {
                _structure.FocusedPA.paId = (int)gridView1.GetFocusedRowCellValue("id");
                _structure.FocusedPA.resposibleId = (int)gridView1.GetFocusedRowCellValue("owner_id");
                _structure.FocusedPA.Account = gridView1.GetFocusedRowCellValue("account").ToString();

                _structure.FocusedPA.Registered = (int)gridView1.GetFocusedRowCellValue("registered");
                _structure.FocusedPA.Lives = (int)gridView1.GetFocusedRowCellValue("lives");
                _structure.FocusedPA.objectId = (int)gridView1.GetFocusedRowCellValue("object_id");

                editAccountButton.Enabled = true;
                deleteAccountButton.Enabled = true;
            }
        }

        private async void addAccountButton_Click(object sender, EventArgs e)
        {
            PAMW pAMW = new PAMW(_objectDataStructure.FocusedObject, _paDataService, _structure.PersonalAccountTable);
            pAMW.ShowDialog();
            await UpdatePAsTable();
        }

        private async void editAccountButton_Click(object sender, EventArgs e)
        {
            if(gridView1.GetFocusedRowCellValue("id") != null)
            {
                PAMW pAMW = new PAMW(_objectDataStructure.FocusedObject, _paDataService, _structure.PersonalAccountTable, _structure.FocusedPA);
                pAMW.ShowDialog();
                await UpdatePAsTable();
            }
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("id") != null)
            {
                _paDataService.DeletePA(_structure.FocusedPA);
            }
        }
    }
}
