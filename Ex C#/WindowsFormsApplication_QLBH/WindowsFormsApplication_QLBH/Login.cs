using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication_QLBH
{
    class Login
    {
        public string username { get; set; }
        public string userpass { get; set; }
        public Login(string user, string pass)
        {
            this.username = user;
            this.userpass = pass;
        }

        private bool StringValidate(string input)
        {
            string pattern = "[^a-zA-Z]";
            if(Regex.IsMatch(input,pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IntergerValidate(string input)
        {
            string pattern = "[^0-9]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ClearText(string user, string pass)
        {
            user = string.Empty;
            pass = string.Empty;
        }

        internal bool IsLoggedIn(string user, string pass)
        {
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Enter the User Name!");
                return false;
            }

            else if (StringValidate(user) == true)
            {
                MessageBox.Show("Enter onytext here");
                ClearText(user, pass);
                return false;
            }

            else
            {
                if(username!= user)
                {
                    MessageBox.Show("User name is incorrect");
                    ClearText(user, pass);
                    return false;
                }
                else if (string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Enter the Password!");
                    return false;
                }

                else if(StringValidate(pass)==true)
                {
                    MessageBox.Show("Enter only interger here");
                    return false;
                }

                else if(userpass!=pass)
                {
                    MessageBox.Show("password is incorrect");
                    ClearText(user,pass);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
