using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.MDWindows.Controllers;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
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
        ObjectDataStructure _objectDataStructure;
        ObjectDataService _objectDataService;
        MDDataStructure _structure;
        MDWindowController _controller;

        public Control ContainerForLoading => throw new NotImplementedException();

        public Control LockControl => throw new NotImplementedException();

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
            gridControlPA.DataSource = _controller.GetPATable(_structure);
        }
        private void BindingMDTable()
        {
            gridControlMW.DataSource = _controller.GetMDTable(_structure);
        }

        private void LoadData()
        {
            LoadObjectsTable();
            LoadPATable();
            LoadMDTable();
        }
        private void LoadObjectsTable()
        {
            GeneralLoadData.LoadData(this,_controller.LoadObjectsTableAsync, _objectDataStructure, _objectDataService);
        }
        private void LoadPATable()
        {

        }
        private void LoadMDTable()
        {

        }

        private void MDWindow_Load(object sender, EventArgs e)
        {
            _controller = new MDWindowController();
            _structure = new MDDataStructure();
            _objectDataStructure = new ObjectDataStructure();
            LoadData();


            BindingData();
        }
    }
}
