using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.PropertiesWindows.Controllers.ServiceControllers;
using CloudyHoa_Client_.PropertiesWindows.MW.Controller;
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

namespace CloudyHoa_Client_.PropertiesWindows.MW
{
    public partial class PropertiesMW : Form, ISafeExecuteControl
    {
        PropertiesSC _propertySC;
        DAO _dataAccessObject;
        PropMWController _controller;

        public Control ContainerForLoading => this;

        public Control LockControl => this;

        public PropertiesMW() { }
        public PropertiesMW(PropertiesSC propertySC,FocusedObject focusedObject)
        {
            InitializeComponent();
            _propertySC = propertySC;
            _dataAccessObject = new DAO(new SPMWDataStructure() { focusedObject = focusedObject });
        }

        private async void PropertiesMW_Load(object sender, EventArgs e)
        {
            _controller = new PropMWController();
            await LoadData();
            _controller.LoadPropertiesAndData(stackPanelProperties, _dataAccessObject, _propertySC);
            PrepareWindow();
        }
        private async Task LoadData()
        {
            await this.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    await Task.Run(() =>
                    {

                        //_controller.LoadTypesObjects(_dataAccessObject);
                        //_controller.LoadAllObjects(_dataAccessObject);
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

        /// <summary>
        /// Установка названия объекта
        /// </summary>
        private void PrepareWindow()
        {
            _controller.SetLabelNameText(labelName, _dataAccessObject);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _controller.SaveSP(_propertySC,_dataAccessObject,stackPanelProperties);
            this.Close();
        }
    }
}
