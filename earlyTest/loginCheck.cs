using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace earlyTest
{
    class loginCheck
    {
        private string _username;
        private string _password;
        private bool _sighnUp;
        private bool _teacher;
        private bool _specialKey;
        private bool _capitalLetter;
        private bool _numberChar;
        private string _confirmPassword;

        public loginCheck(string username, string password)
        {
            Username = username;
            Password = password;
        }


        public loginCheck(string username, string password, string confirmPassword)
        {
            Username = username;
            Password = password;
            ConfirmPassword = confirmPassword;
        }


        public int checkPassword()
        {
            char[] passwordChar = Password.ToArray();
            if (Password == "")
            {
                return 1;
                //1 is the error code for an empty box
            }
            else if (Password != ConfirmPassword)
            {
                return 4;
                //error 4 is when passwords dont match
            }
            else
            {
                if (passwordChar.Any(char.IsSymbol) == true || passwordChar.Any(char.IsSeparator) == true ||passwordChar.Any(char.IsPunctuation) == true)
                {
                    if (passwordChar.Any(char.IsNumber) == true)
                    {
                        return 0;
                        //0 is that all validation is correct;
                    }
                    else
                    {
                        return 3;
                        //3 is that the list doesnt contain a non alphanumerical character
                    }
                }
                else
                {
                    return 2;
                    //2 is that the password doesnt contain any numbers
                }
            }
        }
        

     

        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set { _confirmPassword = value; }

        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public bool signUp
        {
            get { return _sighnUp; }
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
    }
}
