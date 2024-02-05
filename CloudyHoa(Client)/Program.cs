using CloudyHoa_Client_.Authorization;
using CloudyHoa_Client_.General;
using System;
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

            bool workFlag = true;

            while (workFlag)
            {
                if (Auth())
                {
                    MainForm.MainForm mainForm = new MainForm.MainForm();
                    Application.Run(mainForm);
                    workFlag = !mainForm.ExitFlag;
                    //if(mainForm.ExitFlag) 
                    //{ 
                    //    Application.Exit();
                    //}
                }
            }
            
        }
        static bool Auth()
        {
            AuthService authService = null;
            //try
            //{
                authService = new AuthService();
            //}
            //catch (System.ServiceModel.EndpointNotFoundException)
            //{
            //    const string message =
            //    "Сервер недоступен";
            //    const string caption = "Подключение к серверу";
            //    var serverResult = MessageBox.Show(message, caption,
            //                                 MessageBoxButtons.OK,
            //                                 MessageBoxIcon.Error);
            //}
            string login = default;
            string password = default;
            bool remember = false;
            bool auto = false;
            if(authService != null)
            {
                authService.LoadSecure(out login, out password, out auto);
                if (!(string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)) & auto == true)
                {
                    auto = true;
                }
                Form dialog = new LoginForm(authService, login, password, remember, auto);
                dialog.ShowDialog();
                return UserContext.Instance.IsAuthed;
            }
            else
            {
                return false;
            }
        }
    }
}
