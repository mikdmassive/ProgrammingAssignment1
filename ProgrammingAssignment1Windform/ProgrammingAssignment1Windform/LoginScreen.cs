using static System.Net.Mime.MediaTypeNames;
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
            PasswordMessageLabel.Text = "";
            NameMessageLabel.Text = "";
        }

        private bool validateName(string name)
        {
            bool valid = false;
            bool invalidchar = false;
            if (name.Length >= 1 && name.Length <= 15)//len check
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (!(char.IsLetter(name[i])))// charcheck
                    {
                        invalidchar = true;
                    }

                }
                valid = (!invalidchar);//setval
            }

            return valid;
        }
        private void ValidateNameTextBox(TextBox tb)
        {
            string text = tb.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                tb.BackColor = Color.White;
            }
            else
            {
                if (validateName(text))
                {
                    tb.BackColor = Color.LightGreen;

                }
                else
                {
                    tb.BackColor = Color.LightCoral;
                }
            }
        }
        private void ValidateBothNameTextBoxes(object sender, EventArgs e)
        {

            ValidateNameTextBox(FNameTextBox);
            ValidateNameTextBox(LNameTextBox);
            string textF = FNameTextBox.Text;
            string textL = LNameTextBox.Text;

            bool eitherinvalid = ((!validateName(textF) && !string.IsNullOrWhiteSpace(textF))) || ((!validateName(textL) && !string.IsNullOrWhiteSpace(textL)));
            NameMessageLabel.Text = eitherinvalid ? "1) Needs to be 1-15 Characters\n2) Only Letters with no whitespace" : "";
        }

        private void PasswordTextChanged(object sender, EventArgs e)
        {
            string text = passwordTextBox.Text;
            PasswordMessageLabel.Text = "";
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
                    PasswordMessageLabel.Text = $"1) Needs to be {passwordMinLength} - {passwordMaxLength} characters\n2) Contain atleast {passwordMinDigits} digits\n3) Have no whitespace";
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
                    if (theuser.password == LoginPasswordTextBox.Text)//success
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

        private void LoginPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateAccountGroup_Enter(object sender, EventArgs e)
        {

        }

        private void FnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;
            string username = usernameTextBox.Text;
            string fname = FNameTextBox.Text;
            string lname = LNameTextBox.Text;
            if (PasswordValidationCheck(password)&&UsernameValidationCheck(username) && validateName(fname) && validateName(lname))
            {
                this.Hide();
                Program.CreateAccount(username, fname,lname,password);
            }
        }
    }
}
