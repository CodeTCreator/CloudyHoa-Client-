using System;
using System.Windows.Forms;

namespace CloudyHoa_Client_.PropertiesWindows.MW.UserControls
{
    public partial class SPControl_Date : UserControl, ISPControl
    {
        public SPControl_Date()
        {
            InitializeComponent();
        }

        public string GetData()
        {
            return valueControl.Text;
        }

        public void LoadData(string name, string type, string value)
        {
            textEditName.Text = name;
            textEditDataType.Text = type;
            valueControl.Text = value;
        }
    }
}
