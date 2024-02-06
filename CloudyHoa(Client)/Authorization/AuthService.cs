using CloudyHoa_Client_.General;
using CloudyHoa_Client_.Properties;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.Authorization
{
    public class AuthService
    {
        private readonly DataServiceAuth _dataService = new DataServiceAuth();

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
                    Settings.Default.AutoLogin = true;
                    Settings.Default.Save();
                }
                else
                {
                    Settings.Default.AutoLogin = false;
                    Settings.Default.Save();
                }
            }
            return result;
        }

        public void LoadSecure(out string login,out string password,out bool autoLogin)
        {
            login = Settings.Default.Login;
            password = Settings.Default.Password;
            autoLogin = Settings.Default.AutoLogin;

            if((string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)))
            {
                login = null;
                password = null;
                autoLogin = false;
            }
        }
    }

    public class DataServiceAuth
    {
        private ServiceReference1.ServiceHoaAccountClient _serviceClient ;

        public DataServiceAuth()
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
