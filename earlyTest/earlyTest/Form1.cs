using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace earlyTest
{
    public partial class Form1 : Form
    {
        private string _username;
        private string _password;
        private bool _sighnUp;
        private bool _teacher;
        private bool _specialKey;
        private bool _capitalLetter;
        private bool _numberChar;
        private string _confirmPassword;
        Thread forms;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void loginHelpBTN_Click(object sender, EventArgs e)
        {
            helpLBL.Text = "Enter in your user name,this should be your real name. \nIf you're new and don't currently have a username. Click the sign up button";
            //This outputs to the text box 
        }

        private void passwordHelpBTN_Click(object sender, EventArgs e)
        {
            helpLBL.Text = "Sign in with a password. Hint it must contain one special character, one captial letter and one number at least.";
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            username = usernametTXT.Text;
            //Encapsulates the username
            password = passwordTXT.Text;

            if (signUp == true)
            {
                confirmPasswordBTN.Hide();
                confirmPasswordPTC.Hide();
                confirmPasswordTXT.Hide();
                submitBTN.Hide();
                signUpBTN.Show();
                loginBTN.Location = new Point(12, 291);
                signUp = false;
            }
            else
            {
            if (username == "")
                {
                 
                helpLBL.Text = "Error, You have not entered in a user name, please enter one and try again";
                //Tells the user on the help and tips box that they havent entered anything
                }
            else if ( password == "")
                {
                helpLBL.Text = passwordTXT.Text;
                //Tells the user on the help and tips box that they havent entered anything
                }
            else
                {
                this.Close();
                forms = new Thread(openingMainMenu);
                // new main menu
                forms.SetApartmentState(ApartmentState.STA);
                //allows the program to countinue
                forms.Start();
                //starts the interactivty with the form
                }
             }

            }

        private void signUpBTN_Click(object sender, EventArgs e)
        {
            confirmPasswordPTC.Show();
            confirmPasswordTXT.Show();
            confirmPasswordBTN.Show();
            loginBTN.Location = new Point(126,403);
            signUpBTN.Hide();
            submitBTN.Show();
            signUp = true;
        }

        private void confirmPasswordBTN_Click(object sender, EventArgs e)
        {
            helpLBL.Text = "Ensure that the passwords match, this should help you remember your password.";
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            username = usernametTXT.Text;
            //encapsulate sensitive data
            password = passwordTXT.Text;
            //encapsulate sensitive data
            confirmPassword = confirmPasswordTXT.Text;
            confirmPassword = confirmPasswordTXT.Text;
            confirmPassword = confirmPasswordTXT.Text;
            //encapsulate sensitive data
            if (username == "")
            {

                helpLBL.Text = "Error, You have not entered in a user name, please enter one and try again";
                //Tells the user on the help and tips box that they havent entered anything
            }
            else if (passwordTXT.Text== "")
            {
                helpLBL.Text = "You havent entered in a password";
                //Tells the user on the help and tips box that they havent entered anything
            }
            else if (confirmPasswordTXT.Text != passwordTXT.Text)
            {
                helpLBL.Text = "passwords dont match, passwords are case sensitive.";
                //Tells the user on the help and tips box that the passwords dont match
            }
            else
            {
                char[] passwordChar = password.ToArray();

                for (int i = 0; i < password.Length; i++)
                {
                    if (passwordChar[i] == '@'
                         || passwordChar[i] == '!'
                         || passwordChar[i] == '#'
                         || passwordChar[i] == '_'
                         || passwordChar[i] == '-'
                         || passwordChar[i] == '+'
                         || passwordChar[i] == '='
                         || passwordChar[i] == '*'
                         || passwordChar[i] == '&'
                         || passwordChar[i] == '^'
                         || passwordChar[i] == '%'
                         || passwordChar[i] == '$'
                         || passwordChar[i] == '£'
                         || passwordChar[i] == '"'
                         || passwordChar[i] == '`'
                         || passwordChar[i] == '¬'
                         || passwordChar[i] == '{'
                         || passwordChar[i] == '}'
                         || passwordChar[i] == '?'
                         || passwordChar[i] == '}'
                         || passwordChar[i] == '/'
                         || passwordChar[i] == '|')
                    {
                        specialKey = true;
                    }
                }
                 if (password.Any(char.IsUpper))
                 {
                        uppercaseLeter = true;
                 }
                  else if (password.Any(char.IsDigit))
                  {
                    containNumber = true;
                  }
                if (containNumber == false)
                {
                    helpLBL.Text = "The password requriers a number";
                }
                else if (uppercaseLeter == false)
                {
                    helpLBL.Text = "The password requries at least one captial letter";
                }
                else if (specialKey == false)
                {
                    helpLBL.Text = "The password requires a special key";
                }
                else
                {
                helpLBL.Text = "something happened comne back soon";
                }
               
            }
        }



        private void openingMainMenu()
        {
            Application.Run(new Form2(false));
            // this loads the menu 
        }
        public void login(string Username, string Password)
        {

        }
        public void login(string Username, string Password, string ConfirmPassword)
        {

        }
        public string confirmPassword
        {
            get { return _confirmPassword; }
            set { _password = value; }

        }

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        public bool signUp
        {
            get {return _sighnUp; }
            set { _sighnUp = value; }
        }
        public bool teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }
        public bool specialKey
        {
            get { return _specialKey; }
            set { _specialKey = value; }
        }
        public bool uppercaseLeter
        {
            get { return _capitalLetter; }
            set { _capitalLetter = value; }
        }
        private bool containNumber
        {
            get { return _numberChar; }
            set { _numberChar = value; }
        }
        public void passwordTXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
