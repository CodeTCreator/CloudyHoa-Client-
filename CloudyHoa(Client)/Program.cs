using CloudyHoa_Client_.Authorization;
using CloudyHoa_Client_.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Auth())
            {
                Application.Run(new MainForm.MainForm());
            }
        }
        static bool Auth()
        {
            var authService = new AuthService();
            string login = default;
            string password = default;
            bool remember = false;
            bool auto = false;

            authService.LoadSecure(out login, out password);
            if(!(string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)))
            {
                auto = true;
            }
            Form dialog = new LoginForm(authService, login,password,remember,auto);
            dialog.ShowDialog();
            return UserContext.Instance.IsAuthed;
        }
    }
}
