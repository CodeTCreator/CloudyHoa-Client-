using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using CloudyHoa_Client_.ResidentsWindows.Controllers;
using CloudyHoa_Client_.ResidentsWindows.MW;
using CloudyHoa_Client_.SaveExecuteControl;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.ResidentsWindows
{
    public partial class ResidentsWindow : Form, ISafeExecuteControl
    {
        ResidentsWindowController _controller;
        ResidentsDataService _residentsDataService;
        ResidentsDataStructure _structure;
        ObjectDataStructure _objectDataStructure;
        ObjectDataService _objectDataService;


        public Control ContainerForLoading => this;

        public Control LockControl => panelControl;

        public ResidentsWindow()
        {
            InitializeComponent();
        }

        private async void ResidentsWindow_Load(object sender, EventArgs e)
        {
            _controller = new ResidentsWindowController();
            _residentsDataService = new ResidentsDataService();
            _structure = new ResidentsDataStructure();
            _objectDataStructure = new ObjectDataStructure();
            _objectDataService = new ObjectDataService();

            treeListControl1.TreeClick += objectControl_Click;
            residentsGridControl1.ResidentGridClick += residentsControl_Click;
            await LoadData();
            BindingData();
        }

        private void BindingData()
        {
            BindingObjectsTable();
            BindingResidentsTable();
        }
        private void BindingObjectsTable()
        {
            treeListControl1.BindingData(_objectDataStructure.DataTable);
        }
        private void BindingResidentsTable()
        {
            residentsGridControl1.BindingData(_structure.ResidentsTable);
        }


        private async Task LoadData()
        {
            await this.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    //await Task.Run(() =>
                    //{
                    await _controller.LoadObjectsTableAsync(_objectDataService,_objectDataStructure);
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
        private async Task LoadResidentsData()
        {
            await this.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    //await Task.Run(() =>
                    //{
                    await _controller.LoadResidentsTableAsync(_residentsDataService, _structure,_structure.FocusedObject);
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

        private async void objectControl_Click()
        {
            FocusedObject focusedObject = treeListControl1.GetFocusedObject();
            _structure.FocusedObject = focusedObject;
            if(focusedObject.objectId != -1)
            {
                addResidentButton.Enabled = true;
            }
            else
            {
                addResidentButton.Enabled = false;
            }
            await UpdateResidentsTable();
        }
        private async Task UpdateResidentsTable()
        {
            await LoadResidentsData();
            BindingResidentsTable();
            CheckOwnersShare();
            residentsControl_Click();
        }
        private void residentsControl_Click()
        {
            FocusedResident focusedResident = residentsGridControl1.GetFocusedResident();
            if(focusedResident.objectId != -1)
            {
                _structure.FocusedResident = focusedResident;
                editResidentButton.Enabled = true;
                deleteResidentButton.Enabled = true;
            }
            else
            {
                ResetFocusedResident();
            }
            
        }

        private void ResetFocusedResident()
        {
            _structure.FocusedResident = null;
            editResidentButton.Enabled = false;
            deleteResidentButton.Enabled = false;
        }
        private async void deleteResidentButton_ClickAsync(object sender, EventArgs e)
        {
            int? residentId = residentsGridControl1.GetResidentId();
            if (residentId != null)
            {
                _residentsDataService.DeleteResidents((int)residentId);
            }
            await UpdateResidentsTable();
        }
        private async void addResidentButton_Click(object sender, EventArgs e)
        {
            ResidentMW residentMW = new ResidentMW(_structure.FocusedObject, _residentsDataService,0);
            residentMW.ShowDialog();
            await UpdateResidentsTable();
        }
        private async void editResidentButton_Click(object sender, EventArgs e)
        {
            if (_structure.FocusedResident.objectId != -1)
            {
                ResidentMW residentMW = new ResidentMW(_structure.FocusedResident, _structure.FocusedObject, _residentsDataService, 1);
                residentMW.ShowDialog();
                await UpdateResidentsTable();
            }
        }

        private void CheckOwnersShare()
        {
            if (!GeneralMethods.CheckOwnersShare(_structure.ResidentsTable))
            {
                LockTreeList(true);
                svgImageAttention.Visible = true;
            }
            else
            {
                LockTreeList(false);
                svgImageAttention.Visible = false;
            }
        }

        private void LockTreeList(bool flag)
        {
            if (flag)
            {
                treeListControl1.Enabled = false;
            }
            else
            {
                treeListControl1.Enabled = true;
            }
        }
    }
}
