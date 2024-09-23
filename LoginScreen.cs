using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chermak_PA_C969
{
    public partial class LoginScreen : Form
    {
        public List<User> Users = null;
        private string LanguageCode;
        private LoginScreen loginscreen;
        public LoginScreen()
        {
            InitializeComponent();
            InitializeLoginScreen();
            loginscreen = this;
        }

        public void InitializeLoginScreen()
        {
            Users = Database.GetUsers();

            LanguageCode = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            if (LanguageCode == "he")
            {
                MakeLoginScreenHebrew();
            }
            UserTimeZoneLabel.Text = TimeZoneInfo.Local.Id;
            UserTimeZoneLabel.Visible = true;

        }

        private void MakeLoginScreenHebrew()
        {
            TitleLabel.Text = "כותרת";
            UsernameLabel.Text = "שם משתמש";
            PasswordLabel.Text = "סיסמה";
            TimezoneLabel.Text = "אזור זמן";
            LoginButton.Text = "התחברות";
            ExitButton.Text = "יְצִיאָה";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string currentUserName = UsernameTextBox.Text;
            string currentPassword = PasswordTextBox.Text;
            try
            {
                if (currentUserName == "" || currentPassword == "")
                {
                    ActivityLog.LogActivity(currentUserName, false);
                    if (LanguageCode == "he")
                    {
                        throw new MyCustomExceptions("עליך להזין שם משתמש וסיסמה כדי להתחבר.");
                    }
                    throw new MyCustomExceptions("You need to enter a Username and Password to login.");
                }
                User user = LookUpUser(currentUserName);

                if (user == null)
                {
                    ActivityLog.LogActivity(currentUserName, false);
                    if (LanguageCode == "he")
                    {
                        throw new MyCustomExceptions("שם המשתמש הזה אינו חוקי");
                    }
                    throw new MyCustomExceptions("That username is invalid");
                }
                else if (user.Password != currentPassword)
                {
                    ActivityLog.LogActivity(currentUserName, false);
                    if (LanguageCode == "he")
                    {

                        throw new MyCustomExceptions(".הסיסמה הזו לא חוקית");
                    }
                    throw new MyCustomExceptions("That password is invalid.");
                }
                ActivityLog.LogActivity(currentUserName, true);
                Hide();
                Mainscreen form = new Mainscreen(user, loginscreen);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK) 
                {
                    Show();
                    PasswordTextBox.Text = "";
                }

            }
            catch (MyCustomExceptions error)
            {
                ErrorLabel.Text = error.Message;
            }
        }

        private User LookUpUser(string userName)
        {
            foreach (User user in Users)
            {
                if (user.UserName == userName)
                {
                    return user;
                }
            }
            return null;
        }
        //private string daylightsavingschecker(datetime localdatetime)
        //{
        //    if (TimeZoneInfo.Local.IsDaylightSavingTime(localdatetime))
        //    {

        //    }
        //}


        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void UserTimeZoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginScreen_Shown(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_VisibleChanged(object sender, EventArgs e)
        {
            PasswordTextBox.Text = "";
        }
    }
}
