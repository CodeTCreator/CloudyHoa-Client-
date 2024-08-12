using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ResidentsWindows.Controllers;
using CloudyHoa_Client_.ResidentsWindows.MW;
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

namespace CloudyHoa_Client_.PersonalAccountsWindows
{
    public partial class PAControl : UserControl, ISafeExecuteControl
    {
        ResidentsDataService _residentsDataService;
        PAMWStructure _structure = new PAMWStructure();
        ResidentsWindowController _residentWC;

        public FocusedObject FocusedObject { get { return _structure.FocusedObject; } set { _structure.FocusedObject = value; } }

        public ResidentsDataService ResidentsDataService { get {return _residentsDataService; } set { _residentsDataService = value; } }

        public Control ContainerForLoading => this;

        public Control LockControl => tabPane1;
        public PAControl()
        {
            InitializeComponent();
        }

        private async void PAControl_Load(object sender, EventArgs e)
        {
            _residentWC = new ResidentsWindowController();

            residentsGridControl1.ResidentGridClick += residentsControl_Click;
            if (!this.DesignMode)
            {
                await UpdateResidentsTable();
            }
        }

        private async void addResidentButton_Click(object sender, EventArgs e)
        {
            ResidentMW residentMW = new ResidentMW(_structure.FocusedObject, _residentsDataService, 0);
            residentMW.ShowDialog();
            await UpdateResidentsTable();
        }

        private async void editResidentButton_Click(object sender, EventArgs e)
        {
            if (_structure.FocusedResident.objectId != -1)
            {
                ResidentMW residentMW = new ResidentMW(_structure.FocusedResident, _structure.FocusedObject, _residentsDataService, 1);
                residentMW.ShowDialog();
                await UpdateResidentsTable();
            }
        }

        private async void deleteResidentButton_Click(object sender, EventArgs e)
        {
            int? residentId = residentsGridControl1.GetResidentId();
            if (residentId != null)
            {
                _residentsDataService.DeleteResidents((int)residentId);
            }
            await UpdateResidentsTable();
        }

        private async Task UpdateResidentsTable()
        {
            await LoadResidentsData();
            BindingResidentsTable();
            CheckOwnersShare();
            residentsControl_Click();
        }

        private async Task LoadResidentsData()
        {
            await this.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    //await Task.Run(() =>
                    //{
                    //await _residentWC.LoadResidentsTableAsync(_residentsDataService, _structure, _structure.FocusedObject);
                    await LoadResidentsTableAsync();
                    //});
                }
                catch (Exception e)
                {
                    const string caption = "PaControl";
                    var result = MessageBox.Show(e.InnerException.Message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }, "Ошибка подключения к северу.");
        }
        private void BindingResidentsTable()
        {
            residentsGridControl1.BindingData(_structure.ResidentsTable);
        }
        private void CheckOwnersShare()
        {
            if (!GeneralMethods.CheckOwnersShare(_structure.ResidentsTable))
            {
                LockTreeList(true);
                svgImageAttention.Visible = true;
            }
            else
            {
                LockTreeList(false);
                svgImageAttention.Visible = false;
            }
        }

        private void LockTreeList(bool flag)
        {
            if (flag)
            {
                saveButton.Enabled = false;
            }
            else
            {
                saveButton.Enabled = true;
            }
        }

        private void residentsControl_Click()
        {
            FocusedResident focusedResident = residentsGridControl1.GetFocusedResident();
            if (focusedResident.objectId != -1)
            {
                _structure.FocusedResident = focusedResident;
                editResidentButton.Enabled = true;
                deleteResidentButton.Enabled = true;
            }
            else
            {
                ResetFocusedResident();
            }
        }
        private void ResetFocusedResident()
        {
            _structure.FocusedResident = null;
            editResidentButton.Enabled = false;
            deleteResidentButton.Enabled = false;
        }
        public async Task LoadResidentsTableAsync()
        {
            DataTable dataTable = await _residentsDataService.GetResidentsAsync(_structure.FocusedObject.objectId);
            dataTable.TableName = "Residents";
            _structure.ResidentsTable = dataTable;
        }
        private void checkEditCalculations_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditCalculations.Checked == true)
            {
                RegLivCalculation();
                textEditRegistered.Enabled = false;
                textEditLives.Enabled = false;
            }
            else
            {
                textEditRegistered.Enabled = true;
                textEditLives.Enabled = true;
            }
        }
        private void RegLivCalculation()
        {
            int registered = 0;
            int lives = 0;
            foreach (DataRow row in _structure.ResidentsTable.Rows)
            {
                if (row["residence"].ToString() == "True")
                {
                    lives++;
                }
                if (row["registered"].ToString() == "True")
                {
                    registered++;
                }
            }
            textEditLives.Text = lives.ToString();
            textEditRegistered.Text = registered.ToString();
        }

        public void BindingComboBoxData(DataTable dataTable)
        {
            comboBoxResponPerson.DisplayMember = "full_name";
            comboBoxResponPerson.ValueMember = "id";
            comboBoxResponPerson.DataSource = dataTable;
        }
    }
}
