using CloudyHoa_Client_.General;
using CloudyHoa_Client_.ResidentsWindows.Controllers;
using DevExpress.Data.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.ResidentsWindows.MW
{
    public partial class ResidentMW : Form
    {
        FocusedResident _resident;
        FocusedObject _object;
        ResidentsDataService _residentsDataService;
        /// <summary>
        /// mode - режим окна; 0 - создание / 1 - редактирование
        /// </summary>
        int _mode = 0;
        public ResidentMW()
        {
            InitializeComponent();
        }
        public ResidentMW(FocusedResident focusedResident, FocusedObject focusedObject, ResidentsDataService residentsDataService, int mode)
        {
            InitializeComponent();
            _resident = focusedResident;
            _object = focusedObject;
            _residentsDataService = residentsDataService;
            _mode = mode;
        }
        public ResidentMW(FocusedObject focusedObject, ResidentsDataService residentsDataService, int mode)
        {
            InitializeComponent();
            _object = focusedObject;
            _residentsDataService = residentsDataService;
            _mode = mode;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //residentForm1.ResetValue();
        }

        private void ResidentMW_Load(object sender, EventArgs e)
        {
           
            if(_mode == 0)
            {
                saveButton.Click += AddButton_Click;
                _resident = new FocusedResident();
            }
            else
            {
                saveButton.Click += EditButton_Click;
            }
            residentForm1.LoadData(_resident, _object.nameType, _object.identificator);
            _resident.objectId = _object.objectId;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            _resident = residentForm1.GetResident();
            _residentsDataService.AddResidents(_resident);
            //this.Close();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            _resident = residentForm1.GetResident();
            _residentsDataService.EditResidents(_resident);
            //this.Close();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            residentForm1.ResetValue();
        }
    }
}
