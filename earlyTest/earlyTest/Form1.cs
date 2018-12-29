using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace earlyTest
{
    public partial class Form1 : Form
    {
        private string _username;
        private string _password;
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
            if (username == "")
            {
                helpLBL.Text = "Error, You have not entered in a user name, please enter one and try again";
                //Tells the user on the help and tips box that they havent entered anything
            }
            else if ( password == "")
            {
                helpLBL.Text = "Error, You have not entered in a password, please enter in one and try again";
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

        private void openingMainMenu()
        {
            Application.Run(new Form2());
            // this loads the menu -->changes on whether or not teacher mode is enabled tbd
        }
        private string username
        {
            get { return _username; }
            set { _username = value; }
        }
        private string password
        {
            get { return _password; }
            set { _password = value; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
