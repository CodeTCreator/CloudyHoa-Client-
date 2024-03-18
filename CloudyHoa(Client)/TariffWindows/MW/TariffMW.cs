using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.SaveExecuteControl;
using CloudyHoa_Client_.TariffWindows.Controllers;
using CloudyHoa_Client_.TariffWindows.MW.Controllers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.TariffWindows.MW
{
    public partial class TariffMW : Form, ISafeExecuteControl
    {
        
        TariffMWController _controller = new TariffMWController();
        TariffDataService _tariffDataService;
        TariffMWDataStructure _tariffMWDataStructure = new TariffMWDataStructure();

        public Control ContainerForLoading => this;

        public Control LockControl => panelControl1;

        public TariffMW()
        {
            InitializeComponent();
        }
        public TariffMW(Tariff tariff, TariffDataService tariffDataService, FocusedObject focusedObject)
        {
            InitializeComponent();
            _tariffDataService = tariffDataService;
            _controller.SetFocusedObject(focusedObject, _tariffMWDataStructure);
            _controller.SetTariffData(tariff, _tariffMWDataStructure);
        }
        public TariffMW(TariffDataService tariffDataService, FocusedObject focusedObject)
        {
            InitializeComponent();
            _tariffDataService = tariffDataService;
            _controller.SetFocusedObject(focusedObject, _tariffMWDataStructure);
            _controller.SetTariffData(new Tariff(), _tariffMWDataStructure);
        }

        /// <summary>
        /// 0 - создание тарифа; 1 - изменение
        /// </summary>
        private void PrepareForms(int mode)
        {
            labelControl1.Text = "Тип объекта: " + 
                _controller.GetFocusedObject(_tariffMWDataStructure).nameType;
            if(mode == 0)
            {
                universalButton.Click += AddButton_Click;
            }
            else
            {
                universalButton.Click += EditButton_Click;

                textEditName.Text = _controller.GetTariff(_tariffMWDataStructure).Name;
                _controller.SelectValueComboBox(comboBoxService, _controller.GetServiceTable(_tariffMWDataStructure),
                    _controller.GetTariff(_tariffMWDataStructure).metadataId, "id");
                spinEdit1.Value = (decimal)_controller.GetTariff(_tariffMWDataStructure).Value;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_controller.CheckFormsValue(_tariffMWDataStructure))
            {
                _controller.AddTariff(_tariffMWDataStructure, _tariffDataService);
                this.Close();
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (_controller.CheckFormsValue(_tariffMWDataStructure))
            {
                _controller.EditTariff(_tariffMWDataStructure, _tariffDataService);
                this.Close();
            }
        }

        private async void TariffMW_Load(object sender, EventArgs e)
        {
            _controller = new TariffMWController();
            await LoadData();
            BindingDataComboBox();
            if (_controller.GetTariff(_tariffMWDataStructure).Id != 0)
            {
                PrepareForms(1);
            }
            else
            {
                PrepareForms(0);
            }
            
        }

        private void textEditName_EditValueChanged(object sender, EventArgs e)
        {
            _controller.ChangeName(textEditName.Text, _tariffMWDataStructure);
        }
        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {
            _controller.ChangeValue((float)spinEdit1.Value, _tariffMWDataStructure);
        }

        private async Task LoadData()
        {
            await this.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    await Task.Run(() =>
                    {
                        _controller.LoadServices(_tariffDataService, _tariffMWDataStructure);
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

        private void BindingDataComboBox()
        {
            comboBoxService.DisplayMember = "property_name" ;
            comboBoxService.ValueMember = "id";
            comboBoxService.DataSource = _controller.GetServiceTable(_tariffMWDataStructure);
            comboBoxService.SelectedIndex = -1;
        }

        private void comboBoxService_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _controller.ChangeService((int)comboBoxService.SelectedValue, _tariffMWDataStructure);
        }
    }
}
