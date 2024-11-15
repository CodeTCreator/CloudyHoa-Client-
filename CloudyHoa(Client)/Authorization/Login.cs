﻿using CloudyHoa_Client_.Authorization;
using CloudyHoa_Client_.SaveExecuteControl;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_
{
    public partial class LoginForm : Form, ISafeExecuteControl
    {
        private readonly AuthService _authService;
        private bool autoLogin;

        public int ExitFlag { get; set; } = 0;

        public Control ContainerForLoading => this;
        public Control LockControl => panelControl2;
        public LoginForm(AuthService authService, string login, string password,bool remember, bool auto)
        {
            InitializeComponent();
            _authService = authService;
            loginEdit.Text = login;
            passwordEdit.Text = password;
            autoLogin = auto;
            rememberCheckBox.Checked = auto;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //base.OnLoad(e);
            if (autoLogin)
            {
                autoLogin = false;
                _ = SignIn();
            }
        }

        private async void loginButton_Click(object sender, EventArgs e) 
            => await SignIn();
        
        private async Task SignIn()
        {
            var login = loginEdit.Text;
            var password = passwordEdit.Text;
            var remember = rememberCheckBox.Checked;
            if(!(string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)))
            {
                await this.SafeUIExecuteAsync(async () =>
                {
                    try
                    {
                        if (await _authService.Auth(login, password, remember))
                        {
                            //DialogResult = DialogResult.OK;
                            ExitFlag = 1;
                            Close();
                        }
                        else
                        // Сделать проверку доступности сервера / различать неверность логина или пароля
                        {
                            MessageBox.Show(this, "Неверный логин или пароль", null, MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception e)
                    {
                        const string caption = "Подключение к серверу";
                        var result = MessageBox.Show(e.Message, caption,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Error);
                    }
                }, "Ошибка авторизации.");
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing & ExitFlag != 1)
               ExitFlag = -1;
        }
    }
}
