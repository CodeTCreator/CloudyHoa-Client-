using CloudyHoa_Client_.General;
using CloudyHoa_Client_.MDWindows.Controllers;
using CloudyHoa_Client_.MetadataService;
using System;
using System.Data;
using System.Windows.Forms;

namespace CloudyHoa_Client_.MDWindows.MW
{
    public partial class MDMW : Form
    {
        string _objectName = string.Empty;
        string _paNumber = string.Empty;
        int _typeObject = -1;
        DataTable _servicesTable = new DataTable();
        FocusedMD _focusedMD { get; set; } = new FocusedMD();
        MDDataService _mdDataService { get; set; }

        MetadataServiceClient _metadataServiceClient = new MetadataServiceClient();

        /// <summary>
        /// 0 - создание / 1 - редактирование
        /// </summary>
        int _mode = -1;
        public MDMW()
        {
            InitializeComponent();
        }
        public MDMW(int typeObject,string objectName, string paNumber, FocusedMD focusedMD, MDDataService mdDataService)
        {
            InitializeComponent();

            _typeObject = typeObject;
            _objectName = objectName;
            _paNumber = paNumber;
            _focusedMD = focusedMD;
            _mdDataService = mdDataService;

            _mode = 1;
        }

        public MDMW(int typeObject, string objectName, string paNumber,int paId, MDDataService mdDataService)
        {
            InitializeComponent();

            _typeObject = typeObject;
            _objectName = objectName;
            _paNumber = paNumber;
            _mdDataService = mdDataService;
            _focusedMD.personalAccountId = paId;

            _mode = 0;
        }

        private void MDMW_Load(object sender, EventArgs e)
        {
            LoadDataInForm();
            LoadComboBoxData();
            BindingDataComboBox();
            if (_mode == 0)
            {
                saveButton.Click += AddMDButton_Click;
                _focusedMD.serviceId = (int)comboBoxService.SelectedValue;
            }
            else
            {
                saveButton.Click += EditMDButton_Click;
                
            }

        }

        

        private void LoadComboBoxData()
        {
            _servicesTable = _metadataServiceClient.GetServices(_typeObject).Tables[0];
        }
        private void BindingDataComboBox()
        {
            comboBoxService.DataSource = _servicesTable;
            comboBoxService.DisplayMember = "property_name";
            comboBoxService.ValueMember = "id";
        }
        private void LoadDataInForm()
        {
            labelObjectName.Text += " " + _objectName;
            labelControlPA.Text += " " + _paNumber;
            textEditMDNumber.Text = _focusedMD.number;
            dateEditInstallation.DateTime = _focusedMD.installationDate;
            dateEditVerification.DateTime = _focusedMD.verificationDate;
            comboBoxService.SelectedValue = _focusedMD.serviceId;
        }

        private void AddMDButton_Click(object sender, EventArgs e)
        {
            _mdDataService.AddMeteringDevice(_focusedMD.number, _focusedMD.verificationDate, _focusedMD.installationDate,
                _focusedMD.serviceId, _focusedMD.personalAccountId);
            this.Close();
        }
        private void EditMDButton_Click(object sender, EventArgs e)
        {
            _mdDataService.EditMeteringDevice(_focusedMD.meteringDeviceId, _focusedMD.number, _focusedMD.verificationDate, _focusedMD.installationDate,
                _focusedMD.serviceId, _focusedMD.personalAccountId);
            this.Close();
        }

        private void comboBoxService_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _focusedMD.serviceId = (int)comboBoxService.SelectedValue;
        }

        private void textEditMDNumber_EditValueChanged(object sender, EventArgs e)
        {
            _focusedMD.number = textEditMDNumber.Text;
        }

        private void dateEditInstallation_EditValueChanged(object sender, EventArgs e)
        {
            _focusedMD.installationDate = (DateTime)dateEditInstallation.EditValue;
        }

        private void dateEditVerification_EditValueChanged(object sender, EventArgs e)
        {
            _focusedMD.verificationDate = (DateTime)dateEditVerification.EditValue;
        }
    }
}
