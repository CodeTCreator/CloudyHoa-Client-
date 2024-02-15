using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using CloudyHoa_Client_.ObjectWindows.MW;
using CloudyHoa_Client_.ObjectWindows.MW.Controllers.Service_Controller;
using CloudyHoa_Client_.SaveExecuteControl;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.ObjectWindows
{
    public partial class ObjectMW : Form, ISafeExecuteControl
    {

        DAO _dataAccessObject;
        
        ObjectMWController _controller;

        int _hoaId = UserContext.Instance.CurrentUser.hoaId;
        int _formMode = -1;

        public Control ContainerForLoading => this;

        public Control LockControl => xtraTabPageMainInfo;
        public ObjectMW()
        {
            InitializeComponent();
        }

        /// <summary>
        /// mode = 1 : редактирование; mode = 0 : добавление;
        /// </summary>
        /// <param name="mode"></param>
        public ObjectMW(int mode)
        {
            InitializeComponent();
            _formMode = mode;
            PrepareForm();
        }
        private void PrepareForm()
        {
            if(_formMode == 1)
            {
                this.Text = "Редактирование объекта";
            }
            else
            {

            }
        }
        private async void ObjectMW_Load(object sender, EventArgs e)
        {
            _dataAccessObject = new DAO(new ObjectMWDataStructure());
            _controller = new ObjectMWController();
            
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
                        _controller.LoadTypesObjects(_dataAccessObject);
                        _controller.LoadAllObjects(_dataAccessObject);
                    });
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
            comboBoxTypesObjects.DisplayMember = "name";
            comboBoxTypesObjects.ValueMember = "id";
            comboBoxTypesObjects.DataSource = _controller.GetTypeObjectsTable(_dataAccessObject);
        }

        private void comboBoxTypesObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            int typeObject = (int)comboBoxTypesObjects.SelectedValue;
            stackPanelProperties.Controls.Clear();
            _controller.SetTypeObject(_dataAccessObject, typeObject);
            xtraTabPageIndicators.PageEnabled = true;
            comboBoxParents.DataSource = _controller.GetParentsTable(_dataAccessObject, typeObject);
            comboBoxParents.DisplayMember = "name";
            comboBoxParents.ValueMember = "id1";
            comboBoxParents.SelectedIndex = -1;
            LoadProperty(typeObject);
        }
        private void textEditNumber_EditValueChanged(object sender, EventArgs e)
        {
            string identificator = textEditNumber.Text;
            _controller.SetIdentificator(_dataAccessObject, identificator);
        }

        private void comboBoxParents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int parentObject = (int)comboBoxParents.SelectedValue;
            _controller.SetParentObject(_dataAccessObject, parentObject);
        }
        private void LoadProperty(int typeObject)
        {
            _controller.LoadProperty(stackPanelProperties, typeObject, _dataAccessObject);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _controller.AddObject(_dataAccessObject, stackPanelProperties);
        }


    }
}
