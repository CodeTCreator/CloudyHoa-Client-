using CloudyHoa_Client_.General;
using CloudyHoa_Client_.Properties;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CloudyHoa_Client_.Authorization
{
    public class AuthService
    {
        private readonly DataService _dataService = new DataService();

        public async Task<bool> Auth(string login, string password, bool remember)
        {
            User user = null;

            user = await _dataService.SignInAsync(login, password);
            //user = _dataService.SignIn(login, password);

            bool result = user != null;
            if (result)
            {
                UserContext.Instance.CurrentUser = user;
                if (remember)
                {
                    Settings.Default.Login = login;
                    Settings.Default.Password = password;
                    Settings.Default.Save();
                }
            }
            return result;
        }

        public void LoadSecure(out string login,out string password)
        {
            login = Settings.Default.Login;
            password = Settings.Default.Password;

            if((string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)))
            {
                login = null;
                password = null;
            }
        }
    }

    public class DataService
    {
        private ServiceReference1.ServiceHoaAccountClient _serviceClient ;

        public DataService()
        {
            CreatingClient();
        }

        private void CreatingClient()
        {
            _serviceClient = new ServiceReference1.ServiceHoaAccountClient();
            //_serviceClient.Open();
        }
        public User SignIn(string login, string password)
        {
            return new User(CheckAndResult(login, password));
        }

        public async Task<User> SignInAsync(string login, string password)
        {
            //var name = await CheckAndResult(login, password);
            //return new User(name);  
            var name = await CheckAndResultAsync(login, password);
            if(name == null)
            {
                return default;
            }
            else
            {
                return new User(name);
            }
        }
        private string CheckAndResult(string login, string password)
        {
            var name = _serviceClient.Authorization(login, password);
            return name;
        }


        private async Task<string> CheckAndResultAsync(string login, string password)
        {
            try
            {
                var name = await _serviceClient.AuthorizationAsync(login, password);
                return name;
            }
            catch (System.ServiceModel.EndpointNotFoundException)
            {
                const string message =
                "Сервер недоступен";
                const string caption = "Подключение к серверу";
                var serverResult = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                return null;
            }
            
        }
    }
}
