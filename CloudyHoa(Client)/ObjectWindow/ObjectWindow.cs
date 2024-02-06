using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using CloudyHoa_Client_.SaveExecuteControl;
using DevExpress.XtraTreeList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.ObjectWindow
{
    public partial class ObjectWindow : Form, ISafeExecuteControl
    {
        DataObject.DAO _dataAccessObject;
        ObjectWindowController _objectWindowController;
        ObjectDataService _objectDataService;

        public Control ContainerForLoading => this;

        public Control LockControl => tabPane1;

        public ObjectWindow()
        {
            InitializeComponent();
        }

        private void ObjectWindow_Load(object sender, EventArgs e)
        {
            _dataAccessObject = new DataObject.DAO(50,new ObjectDataStructure());
            _objectWindowController = new ObjectWindowController();
            _objectDataService = new ObjectDataService();
            LoadData();
        }

        private async void LoadData()
        {
            await this.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    _objectWindowController.LoadAllObjects(_objectDataService, _dataAccessObject);
                    BindingData();
                }
                catch (Exception e)
                {
                    const string caption = "Подключение к серверу";
                    var result = MessageBox.Show(e.Message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }, "Ошибка подключения к северу.");
           
            //_objectWindowController.LoadObjectsStructureAsync(_objectDataService, _dataAccessObject);
        }

        private void BindingData()
        {
            treeListObject.DataSource = _objectWindowController.GetObjectsTable(_dataAccessObject);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (treeListObject.GetFocusedRowCellValue("id") != null)
            {
                int hoaId = (int)treeListObject.GetFocusedRowCellValue("id");
                _objectWindowController.DeleteObject(_objectDataService, hoaId);
            }
        }

    }
}
