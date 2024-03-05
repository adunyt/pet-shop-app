namespace PetShop
{
    public partial class LoginForm : Form
    {
        // 2. SECOND MAIN MODULE - Auth window //

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public LoginForm()
        {
            InitializeComponent();
            Program.SetAllControlsFont(this.Controls);
        }

        public void ClearForm()
        {
            if (!Program.isLogin)
            {
                loginTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
            }
        }

        // 4. Login button click handler module //
        private void loginButton_Click(object sender, EventArgs e)
        {
            incorrectCredentialsTextBot.Hide();
            bool isUserValid = false;
            try
            {
                isUserValid = Program.CheckCredentials(loginTextBox.Text, passwordTextBox.Text);
            }
            catch (Exception exception)
            {
                Logger.Error(exception, "Error while login attempt");
                MessageBox.Show(caption: $"ОШИБКА: {exception.GetType().Name}", text: "Возника ошибка при входе в аккаунт. Проверьте интернет соединение и повторите попытку. Если ошибка все еще присутствует - сообщите администратору.", buttons: MessageBoxButtons.OK);
            }
            if (!isUserValid)
            {
                Logger.Info("User data is NOT valid, abort");
                incorrectCredentialsTextBot.Show();
                return;
            }
            Logger.Info("User data is valid, continue");
            Program.SwitchToMain();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Logger.Info($"Closing app from {this.Name}");
            base.OnFormClosing(e);
            e.Cancel = true;
            Application.ExitThread();
        }
    }
}
