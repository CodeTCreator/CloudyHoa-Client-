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
                int authFlag = Auth();
                if (authFlag == 1)
                {
                    MainForm.MainForm mainForm = new MainForm.MainForm();
                    Application.Run(mainForm);
                    workFlag = !mainForm.ExitFlag;
                    if (mainForm.ExitFlag)
                    {
                        Application.Exit();
                    }
                }else if(authFlag == -1) { workFlag = false; }
            }
            
        }
        /// <summary>
        /// 1 - успешный вход / 0 - неудачный / -1 - закрыть приложение
        /// </summary>
        /// <returns></returns>
        static int Auth()
        {
            AuthService authService = null;
            try
            {
                authService = new AuthService();
            }
            catch (System.ServiceModel.EndpointNotFoundException)
            {
                const string message =
                "Сервер недоступен";
                const string caption = "Подключение к серверу";
                var serverResult = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
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
                LoginForm dialog = new LoginForm(authService, login, password, remember, auto);
                dialog.ShowDialog();
                if(dialog.ExitFlag == -1) { return -1; }
                return UserContext.Instance.IsAuthed ? 1 : 0;
            }
            else
            {
                return 0;
            }
        }
    }
}
