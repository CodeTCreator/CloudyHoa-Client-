using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.General;
using CloudyHoa_Client_.PersonalAccountsWindows.Controllers;
using CloudyHoa_Client_.ResidentsWindows.Controllers;
using CloudyHoa_Client_.ResidentsWindows.MW;
using CloudyHoa_Client_.SaveExecuteControl;
using DevExpress.XtraGauges.Core.Model;
using System;
using System.Data;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.PersonalAccountsWindows.MW
{
    public partial class PAMW : Form, ISafeExecuteControl
    {

        PAMWStructure _structure = new PAMWStructure();
        ResidentsDataService _residentsDataService;
        PADataService _pADataService;
        /// <summary>
        /// 0 - редактирование / 1 - добавление
        /// </summary>
        int modeWindow = -1;

        public Control ContainerForLoading => this;

        public Control LockControl => panelControl;

        public PAMW()
        {
            InitializeComponent();
        }

        public PAMW(FocusedObject focusedObject, PADataService pADataService, DataTable personalAccountsTable)
        {
            InitializeComponent();
            _structure.FocusedObject = focusedObject;
            _pADataService = pADataService;
            _structure.PersonalAccountsTable = personalAccountsTable;
            modeWindow = 0;
        }
        public PAMW(FocusedObject focusedObject, PADataService pADataService, DataTable personalAccountsTable, FocusedPA focusedPA)
        {
            InitializeComponent();
            _structure.FocusedObject = focusedObject;
            _pADataService = pADataService;
            _structure.PersonalAccountsTable = personalAccountsTable;
            _structure.FocusedPA = focusedPA;
            modeWindow = 1;
        }

        private async void PAMW_Load(object sender, EventArgs e)
        {
            _residentsDataService = new ResidentsDataService();
            residentsGridControl1.ResidentGridClick += residentsControl_Click;
            await UpdateResidentsTable();
            //paControl1.FocusedObject = _structure.FocusedObject;
            //paControl1.ResidentsDataService = new ResidentsWindows.Controllers.ResidentsDataService();
            //paControl1.BindingComboBoxData(_structure.ResidentsTable);
            labelObject.Text += " " + _structure.FocusedObject.nameType + " " + _structure.FocusedObject.identificator;

            if(modeWindow == 0)
            {
                saveButton.Click += AddPersonalAccount;
            }
            else
            {
                textEditPA.Enabled = false;
                saveButton.Click += EditPersonalAccount;
                LoadDataInForm();
            }
        }
        private void LoadDataInForm()
        {
            textEditPA.Text = _structure.FocusedPA.Account;
            textEditLives.Text = _structure.FocusedPA.Lives.ToString();
            textEditRegistered.Text = _structure.FocusedPA.Registered.ToString();
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
            CheckFlags();
            residentsControl_Click();
            BindingComboBoxData();
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

        private void CheckFlags()
        {
            if (CheckOwnersShare() && CheckComboBox())
            {
                saveButton.Enabled = true;
            }
            else
            {
                saveButton.Enabled = false;
            }
        }
        private bool CheckOwnersShare()
        {
            if (!GeneralMethods.CheckOwnersShare(_structure.ResidentsTable))
            {
                //LockTreeList(true);
                svgImageAttention.Visible = true;
                return false;
            }
            else
            {
                //LockTreeList(false);
                svgImageAttention.Visible = false;
                return true;
            }
        }

        //private void LockTreeList(bool flag)
        //{
        //    if (flag && !CheckComboBox())
        //    {
        //        saveButton.Enabled = false;
        //    }
        //    else
        //    {
        //        saveButton.Enabled = true;
        //    }
        //}

        private bool CheckComboBox()
        {
            if(comboBoxResponPerson.SelectedValue == null)
            {
                return false;
            }
            else
            {
                return true;
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

        public void BindingComboBoxData()
        {
            var resultTables = from row in _structure.ResidentsTable.AsEnumerable()
                               where row.Field<int>("object_id") == _structure.FocusedObject.objectId &&
                               !(from personRow in _structure.PersonalAccountsTable.AsEnumerable()
                                 where row.Field<int>("object_id") == _structure.FocusedObject.objectId
                                 select personRow.Field<int>("owner_id")).Contains(row.Field<int>("id")) ||
                               row.Field<int>("id") == _structure.FocusedPA.resposibleId
                               select row;
            comboBoxResponPerson.DisplayMember = "full_name";
            comboBoxResponPerson.ValueMember = "id";
            comboBoxResponPerson.DataSource = resultTables.Count() > 0 ? resultTables.CopyToDataTable() : null;
            comboBoxResponPerson.SelectedValue = _structure.FocusedPA.resposibleId;
        }

        private void comboBoxResponPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void AddPersonalAccount(object sender, EventArgs e)
        {
            _pADataService.AddPA(_structure.FocusedPA);
            this.Close();
        }
        private void EditPersonalAccount(object sender, EventArgs e)
        {
            _pADataService.EditPA(_structure.FocusedPA);
            this.Close();
        }

        private void textEditRegistered_EditValueChanged(object sender, EventArgs e)
        {
            _structure.FocusedPA.Registered = (int)textEditRegistered.Value;
        }

        private void textEditLives_EditValueChanged(object sender, EventArgs e)
        {
            _structure.FocusedPA.Lives = (int)textEditLives.Value;
        }

        private void textEditPA_EditValueChanged(object sender, EventArgs e)
        {
            _structure.FocusedPA.Account = textEditPA.Text;
        }

        private void comboBoxResponPerson_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckFlags();
            _structure.FocusedPA.resposibleId = comboBoxResponPerson.SelectedValue != null ? (int)comboBoxResponPerson.SelectedValue : -1;
        }
    }
}
