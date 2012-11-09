using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shop.Controllers;

namespace Shop.Views
{
    /// <summary>
    /// Class to view user info
    /// </summary>
    public partial class UserControlView : UserControl
    {
        /// <summary>
        /// Main controller
        /// </summary>
        private MainController control;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserControlView"/> class.
        /// </summary>
        /// <param name="ctrl"> main control </param>
        /// <param name="username"> user username </param>
        /// <param name="role"> user status </param>
        public UserControlView(MainController ctrl, string username, string role)
        {
            InitializeComponent();
            control = ctrl;
            this.UsernameLabel.Text = username + "!";
            this.RoleLabel.Text = role + ".";
        }

        /// <summary>
        /// Loging out
        /// </summary>
        /// <param name="sender"> message sender </param>
        /// <param name="e"> event. </param>
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            control.LogOut();
        }

        /// <summary>
        /// Show personal cabinet
        /// </summary>
        /// <param name="sender"> message sender </param>
        /// <param name="e"> events </param>
        private void AccountButton_Click(object sender, EventArgs e)
        {
            control.ShowPersonalCabinet();
        }
    }
}
