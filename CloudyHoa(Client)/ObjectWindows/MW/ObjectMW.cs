using CloudyHoa_Client_.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.ObjectWindows
{
    public partial class ObjectMW : Form
    {
        int _hoaId = UserContext.Instance.CurrentUser.hoaId;
        int _formMode = -1;
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
    }
}
