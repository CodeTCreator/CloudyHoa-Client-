using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.PropertiesWindows.Controllers.ServiceControllers;
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

namespace CloudyHoa_Client_.PropertiesWindows
{
    public partial class PropertiesWindow : Form, ISafeExecuteControl
    {
        DAO _dataAccessObject;
        PropWindowController _controller;
        PropertiesSC _propertySC;

        public Control ContainerForLoading => this;

        public Control LockControl => this;

        public PropertiesWindow()
        {
            InitializeComponent();
        }

        private async void PropertiesWindow_Load(object sender, EventArgs e)
        {
            _dataAccessObject = new DAO(new SPDataStructure());
            _controller = new PropWindowController();
            _propertySC = new PropertiesSC();
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
                        //_objectWindowController.LoadAllObjects(_objectDataService, _dataAccessObject);
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

        }
        private void BindingData()
        {
            //treeListObjects.DataSource = _objectWindowController.GetObjectsTable(_dataAccessObject);


        }

    }
}
