using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
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
        /// <summary>
        /// Main controller
        /// </summary>
        private MainController main;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginControl"/> class.
        /// </summary>
        /// <param name="a">instance of comtroller</param>
        public LoginControl(MainController a)
        {
            InitializeComponent();
            main = a;
        }

        /// <summary>
        /// Gets a-mail
        /// </summary>
        /// <returns> e-mail </returns>
        public string GetUsername
        {
            get { return UsernameTxt.Text; }
        }

        /// <summary>
        /// Gets password
        /// </summary>
        /// <returns> password </returns>
        public string GetPassword
        {
            get { return PasswordTxt.Text; }
        }
        
        /// <summary>
        /// validation login
        /// </summary>
        /// <param name="sender">message sender</param>
        /// <param name="e">event</param>
        private void SignBtn_Click(object sender, EventArgs e)
        {
            main.LogIn(UsernameTxt.Text, PasswordTxt.Text);
        }

        /// <summary>
        /// Loads objects for login control
        /// </summary>
        /// <param name="sender">message sender</param>
        /// <param name="e">event</param>
        private void LoginControl_Load(object sender, EventArgs e)
        {
            // creating tooltip for close icon
            ToolTip signInToolTip = new ToolTip();
            signInToolTip.ShowAlways = true;
            signInToolTip.SetToolTip(SignBtn, "Sign in to your account");
        }

        /// <summary>
        /// Click register button
        /// </summary>
        /// <param name="sender"> message sender </param>
        /// <param name="e"> event </param>
        private void RegistrBtn_Click(object sender, EventArgs e)
        {
            main.Register();
        }
    }
}
