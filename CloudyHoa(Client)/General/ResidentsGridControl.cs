using System;
using System.Data;
using System.Windows.Forms;

namespace CloudyHoa_Client_.General
{
    public partial class ResidentsGridControl : UserControl
    {
        public delegate void residentGridClickHandler();
        public event residentGridClickHandler ResidentGridClick;
        public ResidentsGridControl()
        {
            InitializeComponent();
        }

        public void BindingData(DataTable dataTable)
        {
            gridControlResidents.DataSource = dataTable;
        }
        public int? GetResidentId()
        {
            //int id = -1;
            //if(gridView1.GetFocusedRowCellValue("id") != null)
            //{
            //    id = (int)gridView1.GetFocusedRowCellValue("id");
            //}
            return (int?)gridView1.GetFocusedRowCellValue("id");
        }
        public FocusedResident GetFocusedResident()
        {
            FocusedResident resident = new FocusedResident();
            if(gridView1.GetFocusedRowCellValue("id") != null)
            {
                // System DB NUll
                resident.residentId = (int)gridView1.GetFocusedRowCellValue("id");
                resident.fullName = gridView1.GetFocusedRowCellValue("full_name").ToString();
                resident.registered = bool.Parse(gridView1.GetFocusedRowCellValue("registered").ToString());
                if(resident.registered)
                {
                    resident.registrationData = 
                        DateTime.Parse(gridView1.GetFocusedRowCellValue("registration_date").ToString());
                }
                else
                {
                    resident.registrationData = null;
                }
                resident.residence = bool.Parse(gridView1.GetFocusedRowCellValue("residence").ToString());
                if (resident.residence)
                {
                    resident.checkInDate = DateTime.Parse(gridView1.GetFocusedRowCellValue("check_in_date").ToString());
                }
                else
                {
                    resident.checkInDate = null;
                }
                resident.owner = bool.Parse(gridView1.GetFocusedRowCellValue("owner").ToString());
                if (resident.owner)
                {
                    //string share = gridView1.GetFocusedRowCellValue("owners_share").ToString();
                    //string[] shares = share.Split('/');
                    resident.ownerShareNumerator = (int)gridView1.GetFocusedRowCellValue("owners_share_numerator");
                    resident.ownerShareDenominator = (int)gridView1.GetFocusedRowCellValue("owners_share_denominator");
                }
                resident.objectId = (int)gridView1.GetFocusedRowCellValue("object_id");
            }
            return resident;
        }

        private void gridControlResidents_Click(object sender, EventArgs e)
        {
            //if (gridView1.GetFocusedRowCellValue("id") != null)
            //{
            //    ResidentGridClick.Invoke();
            //}
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue("id") != null)
            {
                ResidentGridClick.Invoke();
            }
        }
    }
}
