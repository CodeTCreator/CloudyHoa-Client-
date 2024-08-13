using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using CloudyHoa_Client_.PropertiesWindows.Controllers.ServiceControllers;
using CloudyHoa_Client_.PropertiesWindows.MW;
using CloudyHoa_Client_.SaveExecuteControl;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.PropertiesWindows
{
    public partial class PropertiesWindow : Form, ISafeExecuteControl
    {
        DAO _dataAccessObject;
        PropWindowController _controller;
        ObjectDataStructure _objectDataStructure;
        ObjectDataService _objectDataService;
        PropertiesSC _propertySC;

        public Control ContainerForLoading => this;

        public Control LockControl => groupBox2;

        public PropertiesWindow()
        {
            Task task = InitializeComponentAsync();
        }

        private async void PropertiesWindow_Load(object sender, EventArgs e)
        {
            _dataAccessObject = new DAO(new SPDataStructure());
            _controller = new PropWindowController();
            _objectDataService = new ObjectDataService();
            _objectDataStructure = new ObjectDataStructure();
            _propertySC = new PropertiesSC();
            await LoadObjectsData();
            BindingData();
        }

        private async Task LoadObjectsData() 
        {
            await this.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    //await Task.Run(() =>
                    //{
                       await _controller.LoadAllObjectAsync(_objectDataService, _objectDataStructure);
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
        private async void BindingData()
        {
            treeListObjects.DataSource = new BindingSource() { DataSource = _controller.GetObjectsTable(_objectDataStructure) };
            await UpdateSPData();
        }
        private async Task UpdateSPData()
        {
            await this.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    await _controller.LoadOldSPAsync(_dataAccessObject, _propertySC, _controller.GetFO(_dataAccessObject).objectId);
                    await _controller.LoadCurrentSPAsync(_dataAccessObject, _propertySC, _controller.GetFO(_dataAccessObject).objectId);
                }
                catch (Exception e)
                {
                    const string caption = "Подключение к серверу";
                    var result = MessageBox.Show(e.InnerException.Message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }, "Ошибка подключения к северу.");
            gridControlOldSP.DataSource = _controller.GetOldSP(_dataAccessObject);
            gridControlCurrSP.DataSource = _controller.GetCurrentSP(_dataAccessObject);
        }

        private async void treeListObjects_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (treeListObjects.GetFocusedRowCellValue("id") != null)
            {
                _controller.UpdateFocusedObject(_dataAccessObject,
                    (int)treeListObjects.GetFocusedRowCellValue("id"),
                    (int)treeListObjects.GetFocusedRowCellValue("id1"),
                    (string)treeListObjects.GetFocusedRowCellValue("identificator"),
                    treeListObjects.GetFocusedRowCellValue("parent_id") != DBNull.Value ?
                    (int)treeListObjects.GetFocusedRowCellValue("parent_id") : (int?)null,
                    (string)treeListObjects.GetFocusedRowCellValue("name"));
                labelControlNameObject.Text = "Объект: " + treeListObjects.GetFocusedRowCellValue("name") + " " + 
                    treeListObjects.GetFocusedRowCellValue("identificator");
                await UpdateSPData();
            }
        }

        private async void editButton_Click(object sender, EventArgs e)
        {
            PropertiesMW propertiesMW = new PropertiesMW(_propertySC,_controller.GetFO(_dataAccessObject));
            propertiesMW.ShowDialog();
            await UpdateSPData();
        }
    }
}
