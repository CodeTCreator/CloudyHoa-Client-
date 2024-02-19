using CloudyHoa_Client_.Properties;
using CloudyHoa_Client_.PropertiesWindows;
using System;
using System.Windows.Forms;

namespace CloudyHoa_Client_.MainForm
{
    public partial class MainForm : Form
    {

        bool _exitFlag = true;

        public bool ExitFlag
        {
            get { return _exitFlag; }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Settings.Default.AutoLogin = false;
            _exitFlag = false;
            this.Close();
        }

        private void objectButton_Click(object sender, EventArgs e)
        {
            
        }

        private void propButton_Click(object sender, EventArgs e)
        {
            PropertiesWindow propertiesWindow = new PropertiesWindow(); 
            propertiesWindow.ShowDialog();
        }
    }
}
