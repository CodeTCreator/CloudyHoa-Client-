using CloudyHoa_Client_.MDWindows;
using CloudyHoa_Client_.PersonalAccountsWindows;
using CloudyHoa_Client_.EnteringReadingsWindows;
using CloudyHoa_Client_.Properties;
using CloudyHoa_Client_.ResidentsWindows;
using CloudyHoa_Client_.PropertiesWindows;
using CloudyHoa_Client_.TariffWindows;
using System;
using System.Windows.Forms;
using CloudyHoa_Client_.CHWindows;

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
            this.Visible = false;
            ObjectWindow.ObjectWindow objectWindow = new ObjectWindow.ObjectWindow();
            objectWindow.ShowDialog();
            this.Visible = true;
        }

        private void propButton_Click(object sender, EventArgs e)
        {
            PropertiesWindow propertiesWindow = new PropertiesWindow(); 
            propertiesWindow.ShowDialog();
        }

        private void residentsButton_Click(object sender, EventArgs e)
        {
            ResidentsWindow residentsWindow = new ResidentsWindow();
            residentsWindow.Show();
        }

        private void paButton_Click(object sender, EventArgs e)
        {
            PAWindow pAWindow = new PAWindow();
            pAWindow.Show();
        }

        private void MDButton_Click(object sender, EventArgs e)
        {
            MDWindow mDWindow = new MDWindow();
            mDWindow.ShowDialog();
        }

        private void tariffButton_Click(object sender, EventArgs e)
        {
            TariffWindow tariffWindow = new TariffWindow();
            tariffWindow.Show();
        }

        private void enteringReadingButton_Click(object sender, EventArgs e)
        {
            EnteringReadingWindow enteringReadingWindow = new EnteringReadingWindow();
            enteringReadingWindow.ShowDialog();
        }

        private void calculationButton_Click(object sender, EventArgs e)
        {
            CalculationWindows.CalculationWindow calculationWindow = new CalculationWindows.CalculationWindow();
            calculationWindow.Show();
        }

        private void historyEnteringButton_Click(object sender, EventArgs e)
        {
            EHWindows.EHWindow eHWindow = new EHWindows.EHWindow();
            eHWindow.Show();
        }

        private void historyCalculatingButton_Click(object sender, EventArgs e)
        {
            CHWindow cHWindowq = new CHWindow();
            cHWindowq.Show();
        }
    }
}
