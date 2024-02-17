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

        DAO _dataAccessObject = new DAO(new ObjectMWDataStructure());

        ObjectMWController _controller = new ObjectMWController();

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

        }
        private void PrepareForms()
        {
            if(_formMode == 1)
            {
                this.Text = "Редактирование объекта";
                if(_controller.GetTypeObject(_dataAccessObject) == -1)
                {
                    const string body = "Не удалось загрузить данные объекта";
                    const string caption = "Загрузка данных";
                    var result = MessageBox.Show(body, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    // Загрузка данных из объекта FocusedObject
                    _controller.SettingFocusingObject(_dataAccessObject);
                    // Установить индекс в двух comboBox
                    int type_object = _controller.GetTypeObject(_dataAccessObject);
                    _controller.SelectValueComboBox(comboBoxTypesObjects, _controller.GetTypeObjectsTable(_dataAccessObject),
                        type_object, "id");
                    _controller.SettingFocusingObject(_dataAccessObject);
                    //comboBoxTypesObjects.SelectedValue = _controller.GetTypeObject(_dataAccessObject);
                    _controller.SelectValueComboBox(comboBoxParents, _controller.GetParentsTable(_dataAccessObject, type_object),
                        _controller.GetParentObject(_dataAccessObject) != null ?
                        _controller.GetParentObject(_dataAccessObject).Value : -1, "id1");
                    //comboBoxParents.SelectedIndex = _controller.GetParentObject(_dataAccessObject) != null ?
                    //    _controller.GetParentObject(_dataAccessObject).Value : -1;

                    textEditNumber.Text = _controller.GetIdentificator(_dataAccessObject);
                }
                xtraTabPageBenefits.PageEnabled = false;
                xtraTabPageIndicators.PageEnabled = false;
                comboBoxTypesObjects.Enabled = false;
                checkEditBenefits.Enabled = false;
                universalButton.Click += editButton_Click;
            }
            else
            {
                universalButton.Click += saveButton_Click;
            }
        }

        public void LoadDataInForm(FocusedObject focusedObject)
        {
            _controller.LoadFO(focusedObject,_dataAccessObject);
        } 
        private async void ObjectMW_Load(object sender, EventArgs e)
        {
            await LoadData();
            PrepareForms();
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
            if(comboBoxParents.SelectedValue != null)
            {
                int parentObject = (int)comboBoxParents.SelectedValue;
                _controller.SetParentObject(_dataAccessObject, parentObject);
            }
        }
        private void LoadProperty(int typeObject)
        {
            _controller.LoadProperty(stackPanelProperties, typeObject, _dataAccessObject);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _controller.AddObject(_dataAccessObject, stackPanelProperties);
            this.Close();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            _controller.EditObject(_dataAccessObject);
            this.Close();
        }

        private void comboBoxTypesObjects_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int typeObject = (int)comboBoxTypesObjects.SelectedValue;
            stackPanelProperties.Controls.Clear();
            _controller.SetTypeObject(_dataAccessObject, typeObject);

            comboBoxParents.DataSource = _controller.GetParentsTable(_dataAccessObject, typeObject);
            comboBoxParents.DisplayMember = "name";
            comboBoxParents.ValueMember = "id1";
            comboBoxParents.SelectedIndex = -1;
            LoadProperty(typeObject);
        }
    }
}
