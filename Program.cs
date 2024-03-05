using PetShop.Models;
using System.Drawing.Text;
using static System.Windows.Forms.Control;

namespace PetShop
{
    internal static class Program
    {
        // 1. FIRST MAIN MODULE - Base app class (start and mics funcs) //

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public static LoginForm loginForm { private set; get; }
        public static MainForm mainForm { private set; get; }

        public static UserType? UserType { private set; get; }
        public static bool isLogin { private set; get; } = false;

        private static PrivateFontCollection privateFonts;

        // 1. Start module // start point of app: font creation, forms creations, start app
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();

                Logger.Info($"Adding Roboto font to PrivateFontCollection");
                privateFonts = new PrivateFontCollection();
                privateFonts.AddFontFile("Roboto-Regular.ttf");

                Logger.Info($"Creating forms");
                loginForm = new();
                mainForm = new();

                Logger.Info($"Show login form");
                loginForm.Show();
            }
            catch (Exception e)
            {
                Logger.Fatal(e, $"Error while starting app!");
                var result = MessageBox.Show(caption: "ÊÐÈÒÈ×ÅÑÊÀß ÎØÈÁÊÀ!",
                    text: $"{e}",
                    icon: MessageBoxIcon.Hand,
                    buttons: MessageBoxButtons.OK);
                Application.ExitThread();
            }
            Application.Run();
        }
        
        public static void SetAllControlsFont(ControlCollection ctrls)
        {
            Logger.Info($"Assing font to all controls of {ctrls.Owner}");
            foreach (Control c in ctrls)
            {
                if (c.Controls != null)
                {
                    SetAllControlsFont(c.Controls);
                }
                c.Font = new Font(privateFonts.Families[0], c.Font.Size);
            }
        }

        // 2. Check credentials module //
        public static bool CheckCredentials(string username, string password)
        {
            Logger.Info($"Checking credentials of user");
            using var context = new Data.zooContext();
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


        // 3. Switch forms module //
        
        public static void SwitchToMain()
        {
            Logger.Info($"Changing form to main");
            isLogin = true;
            loginForm.Hide();
            mainForm.Show();
            mainForm.MainForm_Shown();
        }

        public static void SwitchToLogin()
        {
            Logger.Info($"Changing form back to login");
            isLogin = false;
            mainForm.Hide();
            loginForm.ClearForm();
            loginForm.Show();
        }

    }
}