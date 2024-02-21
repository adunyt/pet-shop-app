using WinFormsApp1.Models;

namespace WinFormsApp1
{
    internal static class Program
    {
        public static LoginForm loginForm { private set; get; } = new();
        public static MainForm mainForm { private set; get; } = new();

        public static UserType? UserType { private set; get; }
        public static bool isLogin { private set; get; } = false;


        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            loginForm.Show();
            Application.Run();
        }

        public static bool CheckCredentials(string username, string password)
        {
            if (username == "manager" && password == "")
            {
                UserType = new() { EmployeeTypeId = 0, Name = "Manager" };
                return true;
            }
            if (username == "seller" && password == "")
            {
                UserType = new() { EmployeeTypeId = 0, Name = "Seller" };
                return true;
            }

            return false;
        }

        public static void SwitchToMain()
        {
            isLogin = true;
            loginForm.Hide();
            mainForm.Show();
            mainForm.MainForm_Shown();
        }

        public static void SwitchToLogin()
        {
            isLogin = false;
            mainForm.Hide();
            loginForm.ClearForm();
            loginForm.Show();
        }

    }
}