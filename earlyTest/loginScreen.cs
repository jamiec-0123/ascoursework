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
    public partial class loginScreen : Form
    {
        public bool signUp;
        Thread forms;
        //enistilises the vairables
        public loginScreen()
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
            loginCheck login = new loginCheck(usernametTXT.Text,passwordTXT.Text);
            int error = login.checkPassword();
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

                this.Close();
                forms = new Thread(openingMainMenu);
                // new main menu
                forms.SetApartmentState(ApartmentState.STA);
                //allows the program to countinue
                forms.Start();
                //starts the interactivty with the form
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
            loginCheck login = new loginCheck(usernametTXT.Text, passwordTXT.Text, confirmPasswordTXT.Text);
            int error = login.checkPassword();
            switch (error)
            {
                case (1):
                    helpLBL.Text = "The password box is empty";
                    break;
                case (2):
                    helpLBL.Text = "There are no numbers";
                    break;
                case (3):
                    helpLBL.Text = "There is no numbers";
                    break;
                case (4):
                    helpLBL.Text = "The passwords dont match";
                    break;
                case (0):
                    helpLBL.Text = "Welcome";
                    this.Close();
                    forms = new Thread(openingMainMenu);
                    // new main menu
                    forms.SetApartmentState(ApartmentState.STA);
                    //allows the program to countinue
                    forms.Start();
                    //starts the interactivty with the form
                    break;
            }
        }



        private void openingMainMenu()
        {
            Application.Run(new mainMenu(true ));
            // The boolean is the teacher mode
        }





        public void login(string Username, string Password)
        {

        }
        public void login(string Username, string Password, string ConfirmPassword)
        {

        }
        public void passwordTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmPasswordTXT_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
