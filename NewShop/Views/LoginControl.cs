using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shop.AppData;
using Shop.Controllers;
using Shop.Models;

namespace Shop.Views
{
    /// <summary>
    /// Form for login.
    /// </summary>
    public partial class LoginControl : UserControl
    {
        private MainController main;
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginControl"/> class.
        /// </summary>
        public LoginControl(MainController a)
        {
            InitializeComponent();
            main = a;
        }
        private User myUser;
        public User MyUser()
        {
            return myUser;
        }
        /// <summary>
        /// get a-mail
        /// </summary>
        /// <returns> e-mail </returns>
        public string getEmail()
        {
            return EmailTxt.Text;
        }
        /// <summary>
        /// get password
        /// </summary>
        /// <returns> password </returns>
        public string getPassword()
        {
            return PasswordTxt.Text;
        }
        /// <summary>
        /// check whether this user is registered
        /// </summary>
        /// <param name="users">users lit</param>
        public bool EquilUser(List<User> users)
        {
            bool isUser = false;
            foreach (User x in users)
            {
                if (getEmail() == x.Email && x.Password == getPassword())
                {
                    isUser = true;
                    myUser = x;
                    myUser.Status = x.Status;
                    break;
                }
            }
            return isUser;
        }
        /// <summary>
        /// check whether this user is registered already
        /// </summary>
        /// <param name="users">users lit</param>
        public void validationLogin()
        {
            Repository repos = Repository.Instance;
            List<User> users = repos.GetAllUsers();

            if (EquilUser(users))
            {
                main.SetStatusLogin(true);
                Dispose();
            }
            else
            {
                // No messages,using tooltip or errorflags instead
                //main.ShowMessage("Format of password or login is incorrect");
            }
        }
        private void SignBtn_Click(object sender, EventArgs e)
        {
            validationLogin();
        }

        private void LoginControl_Load(object sender, EventArgs e)
        {
            // creating tooltip for close icon
            ToolTip signInToolTip = new ToolTip();
            signInToolTip.ShowAlways = true;
            signInToolTip.SetToolTip(SignBtn, "Sign in to your account");

            
        }
    }
}
