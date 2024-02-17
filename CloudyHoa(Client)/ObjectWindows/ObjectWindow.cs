using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using CloudyHoa_Client_.ObjectWindows;
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
        FocusedObject _focusedObject;
        public Control ContainerForLoading => this;

        public Control LockControl => tabPane1;

        public ObjectWindow()
        {
            InitializeComponent();
        }

        private async void ObjectWindow_Load(object sender, EventArgs e)
        {
            _dataAccessObject = new DataObject.DAO(new ObjectDataStructure());
            _objectWindowController = new ObjectWindowController();
            _objectDataService = new ObjectDataService();
            _focusedObject = new FocusedObject();
            await LoadData();
        }
        private async Task LoadData()
        {
            await this.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    await Task.Run(() =>
                    {
                        _objectWindowController.LoadAllObjects(_objectDataService, _dataAccessObject);
                        BindingData();
                    });
                   
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
            gridControl1.DataSource = 
                from objectC in _objectWindowController.GetObjectsTable(_dataAccessObject).AsEnumerable()
                group objectC by objectC["name"] into ob
                select new {name = ob.Key, count =  ob.Count()};

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (treeListObject.GetFocusedRowCellValue("id") != null)
            {
                int objectId = (int)treeListObject.GetFocusedRowCellValue("id");
                _objectWindowController.DeleteObject(_objectDataService, objectId);
                _objectWindowController.LoadAllObjects(_objectDataService,_dataAccessObject);
                BindingData();
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            ObjectMW objectMW = new ObjectMW(0);
            objectMW.ShowDialog();
            UpdateBindings();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if (treeListObject.GetFocusedRowCellValue("id") != null)
            {
                ObjectMW objectMW = new ObjectMW(1);
                objectMW.LoadDataInForm(_focusedObject);
                objectMW.ShowDialog();
                UpdateBindings();
            }
        }
        private void UpdateBindings()
        {
            _objectWindowController.LoadAllObjects(_objectDataService, _dataAccessObject);
            BindingData();
        }

        private void treeListObject_SelectionChanged(object sender, EventArgs e)
        {
            if (treeListObject.GetFocusedRowCellValue("id") != null)
            {
                _focusedObject.objectId = (int)treeListObject.GetFocusedRowCellValue("id");
                _focusedObject.typeObject = (int)treeListObject.GetFocusedRowCellValue("id1");
                _focusedObject.identificator = treeListObject.GetFocusedRowCellValue("identificator").ToString();

                _focusedObject.parentId = treeListObject.GetFocusedRowCellValue("parent_id") != DBNull.Value ?
                    (int)treeListObject.GetFocusedRowCellValue("parent_id") : (int?)null;
                _focusedObject.nameType = treeListObject.GetFocusedRowCellValue("name").ToString();
            }
        }
    }
}
