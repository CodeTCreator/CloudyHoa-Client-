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
            var hoaId = CheckAndResult(login, password);
            var name = GetAccountName(hoaId);
            return new User(name, hoaId);
        }

        public async Task<User> SignInAsync(string login, string password)
        {
            //var name = await CheckAndResult(login, password);
            //return new User(name);  
            var hoaId = await CheckAndResultAsync(login, password);
            
            
            if(hoaId == -1)
            {
                return default;
            }
            else
            {
                var name = GetAccountName(hoaId);
                User user = new User(name, hoaId);
                return user;
            }
        }
        private int CheckAndResult(string login, string password)
        {
            var hoaId = _serviceClient.Authorization(login, password);
            return hoaId;
        }


        private async Task<int> CheckAndResultAsync(string login, string password)
        {
            try
            {
                var hoaId = await _serviceClient.AuthorizationAsync(login, password);
                return hoaId;
            }
            catch (System.ServiceModel.EndpointNotFoundException)
            {
                const string message =
                "Сервер недоступен";
                const string caption = "Подключение к серверу";
                var serverResult = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
                return -1;
            }
        }
        private string GetAccountName(int hoaId)
        {
            try
            {
                var name =  _serviceClient.GetAccountName(hoaId);
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
