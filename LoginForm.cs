namespace PetShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void ClearForm()
        {
            if (!Program.isLogin)
            {
                loginTextBox.Text = string.Empty;
                passwordTextBox.Text = string.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

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
                MessageBox.Show(caption: $"������: {exception.GetType().Name}", text: "������� ������ ��� ����� � �������. ��������� �������� ���������� � ��������� �������. ���� ������ ��� ��� ������������ - �������� ��������������.", buttons: MessageBoxButtons.OK);
            }
            if (!isUserValid)
            {
                incorrectCredentialsTextBot.Show();
                return;
            }
            Program.SwitchToMain();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = true;
            Application.ExitThread();
        }
    }
}
