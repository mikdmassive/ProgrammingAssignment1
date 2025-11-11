using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProgrammingAssignment1Windform
{
    public partial class LoginScreen : Form
    {
        static List<User> Users = new List<User>();

        static int usernameMaxLen = 10;
        static int usernameMinLen = 4;

        static int passwordMinLength = 8;
        static int passwordMaxLength = 16;
        static int passwordMinDigits = 2;
        static bool PasswordValidationCheck(string password)
        {
            bool valid = false;
            bool ws = false;



            if (password.Length >= passwordMinLength && password.Length <= passwordMaxLength)//len check
            {
                int numCount = 0;
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsDigit(password[i]))//digit check
                    {
                        numCount++;
                    }
                    else if (char.IsWhiteSpace(password[i]))//space check
                    {
                        ws = true;
                    }
                }
                valid = (numCount >= passwordMinDigits && !ws);//setval
            }
            return valid;
        }
        static bool UsernameInUse(string username)
        {
            foreach (User user in Users)
            {
                if (user.username == username)
                {
                    return true;
                }
            }
            return false;
        }
        static bool UsernameValidationCheck(string username)
        {
            bool valid = false;

            bool invalidchar = false;

            if (username.Length >= usernameMinLen && username.Length <= usernameMaxLen)//len check
            {
                for (int i = 0; i < username.Length; i++)
                {
                    if (!(char.IsDigit(username[i]) || char.IsLetter(username[i])))// charcheck
                    {
                        invalidchar = true;
                    }

                }
                valid = (!invalidchar);//setval
            }
            if (valid)
            {
                if (UsernameInUse(username))
                {
                    valid = false;

                }
            }
            return valid;
        }
        public LoginScreen(List<User> users)
        {
            Users = users;
            InitializeComponent();
            UsernameMessageLabel.Text = "";
        }

        private void PasswordTextChanged(object sender, EventArgs e)
        {
            string text = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(text))
            {
                passwordTextBox.BackColor = Color.White;
            }
            else
            {
                if (PasswordValidationCheck(text))
                {
                    passwordTextBox.BackColor = Color.LightGreen;
                }
                else
                {
                    passwordTextBox.BackColor = Color.LightCoral;
                }
            }

        }

        private void UsernameTextChange(object sender, EventArgs e)
        {
            string text = usernameTextBox.Text;
            UsernameMessageLabel.Text = "";
            if (string.IsNullOrWhiteSpace(text))
            {
                usernameTextBox.BackColor = Color.White;
            }
            else
            {
                if (UsernameValidationCheck(text))
                {
                    usernameTextBox.BackColor = Color.LightGreen;

                }
                else
                {
                    UsernameMessageLabel.Text = UsernameInUse(text) ? "Username In Use" : $"1) Needs to be {usernameMinLen} - {usernameMaxLen} characters/digits\n2) No spaces or symbols";
                    usernameTextBox.BackColor = Color.LightCoral;
                }
            }
        }

        private void LoginUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = LoginUsernameTextBox.Text;
            if (UsernameInUse(text))
            {
                LoginUsernameTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                LoginUsernameTextBox.BackColor = Color.White;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = LoginUsernameTextBox.Text;
            if (UsernameInUse(username))
            {
                User theuser = null;
                foreach (User user in Users)
                {
                    if (user.username == username)
                    {
                        theuser = user;
                    }
                }
                if (theuser != null)//check password
                {
                    if(theuser.password == LoginPasswordTextBox.Text)//success
                    {
                        //todo : login
                        this.Hide();
                        Program.Login(theuser);
                    }
                    else
                    {
                        LoginPasswordTextBox.Text = "";
                    }
                
                }
            }
        }
    }
}
