using System;

using System.Windows.Forms;

namespace CloudyHoa_Client_.General
{
    public partial class ResidentForm : UserControl
    {
        //public delegate void dataChangingHandler();
        //public event dataChangingHandler dataChangingEvent;


        FocusedResident _focusedResident = new FocusedResident();
        string _objectName;
        string _objectNumber;

        public ResidentForm()
        {
            InitializeComponent();
        }
        public void LoadData(FocusedResident focusedResident, string objectName, string objectNumber)
        {
            _focusedResident = focusedResident;
            _objectName = objectName;
            _objectNumber = objectNumber;
            SetValue();
        }
        private void SetValue()
        {
            labelObjectName.Text = "Объект: " + _objectName + " " + _objectNumber;
            textEditFIO.Text = _focusedResident.fullName;
            checkReg.Checked = _focusedResident.registered;
            checkLives.Checked = _focusedResident.residence;
            if (_focusedResident.registrationData.HasValue)
            {
                dateEditRegistration.DateTime = (DateTime)_focusedResident.registrationData;
            }
            if (_focusedResident.checkInDate.HasValue)
            {
                dateEditCheckIn.DateTime = (DateTime)_focusedResident.checkInDate;
            }
            
            if (_focusedResident.owner)
            {
                textEditNumerator.Value = (decimal)_focusedResident.ownerShareNumerator;
                textEditDenominator.Value = (decimal)_focusedResident.ownerShareDenominator;
            }
            checkOwner.Checked = _focusedResident.owner;
        }

        public FocusedResident GetResident()
        {
            return _focusedResident;
            //    new FocusedResident
            //{
            //    fullName = textEditFIO.Text,
            //    registered = checkReg.Checked,
            //    residence = checkLives.Checked,
            //    registrationData = dateEditRegistration.DateTime,
            //    checkInDate = dateEditRegistration.DateTime,
            //    owner = checkOwner.Checked,
            //    ownerShareNumerator = 1,
            //    ownerShareDenominator = 1,
            //};
        }
        public void ResetValue()
        {
            textEditFIO.Text = string.Empty;
            checkReg.Checked = false;
            checkLives.Checked = false;
            checkOwner.Checked = false;
            dateEditRegistration.EditValue = null;
            dateEditCheckIn.EditValue = null;
            textEditNumerator.Value = 1;
            textEditDenominator.Value = 1;
        }

        private void checkEditOwner_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkOwner.Checked)
            {
                textEditNumerator.Enabled = false;
                textEditDenominator.Enabled = false;
                //textEditNumerator.EditValue = null;
                //textEditDenominator.EditValue = null;
                _focusedResident.ownerShareNumerator = null;
                _focusedResident.ownerShareDenominator = null;

                _focusedResident.owner = false;
            }
            else
            {
                textEditNumerator.Enabled = true;
                textEditDenominator.Enabled = true;

                _focusedResident.ownerShareNumerator = (int)textEditNumerator.Value;
                _focusedResident.ownerShareDenominator = (int)textEditDenominator.Value;
                _focusedResident.owner = true;
            }
            //dataChangingEvent.Invoke();
        }

        private void textEditFIO_EditValueChanged(object sender, EventArgs e)
        {
            _focusedResident.fullName = textEditFIO.Text;
            //dataChangingEvent.Invoke();
        }

        private void checkReg_CheckedChanged(object sender, EventArgs e)
        {
            dateEditRegistration.Enabled = checkReg.Checked;
            _focusedResident.registered = checkReg.Checked;
            if (checkReg.Checked)
            {
                _focusedResident.registrationData = dateEditRegistration.DateTime;
            }
            else
            {
                _focusedResident.registrationData = null;
            }
            //dataChangingEvent.Invoke();
        }

        private void checkLives_CheckedChanged(object sender, EventArgs e)
        {
            dateEditCheckIn.Enabled = checkLives.Checked;
            _focusedResident.residence = checkLives.Checked;
            if (checkLives.Checked)
            {
                _focusedResident.checkInDate = dateEditCheckIn.DateTime;
            }
            else
            {
                _focusedResident.checkInDate = null;
            }
            //dataChangingEvent.Invoke();
        }

        private void dateEditRegistration_EditValueChanged(object sender, EventArgs e)
        {
            _focusedResident.registrationData = (DateTime?)dateEditRegistration.DateTime;        
        }

        private void dateEditCheckIn_EditValueChanged(object sender, EventArgs e)
        {
            _focusedResident.checkInDate = (DateTime?)dateEditCheckIn.DateTime;
        }

        private void textEditNumerator_ValueChanged(object sender, EventArgs e)
        {
            _focusedResident.ownerShareNumerator = Convert.ToInt32(textEditNumerator.Value);
        }
        private void textEditDenominator_ValueChanged(object sender, EventArgs e)
        {
            _focusedResident.ownerShareDenominator = Convert.ToInt32(textEditDenominator.Value);
        }


    }
}
