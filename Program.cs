using PetShop.Models;

namespace PetShop
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
            try
            {
                loginForm.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(caption: "ÊÐÈÒÈ×ÅÑÊÀß ÎØÈÁÊÀ!",
                    text: $"{e}",
                    icon: MessageBoxIcon.Hand,
                    buttons: MessageBoxButtons.OK);
                return;
            }            
            Application.Run();
        }

        public static bool CheckCredentials(string username, string password)
        {
            using var context = new Data.ZooContext();
            User? user = context.Users.FirstOrDefault(x => x.Login == username);
            if (user == null) 
                return false;
            var result = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
            if (result)
            {
                UserType = context.UserTypes.FirstOrDefault(x => x.EmployeeTypeId == user.UserTypeId);
            }
            return result;

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