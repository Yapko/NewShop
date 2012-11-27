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

namespace Shop.Views
{
    /// <summary>
    /// admin's view
    /// </summary>
    public partial class AdminView : UserControl
    {
        /// <summary>
        /// main controller
        /// </summary>
        private MainController control;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminView"/> class.
        /// </summary>
        /// <param name="main">main control</param>
        public AdminView(MainController main)
        {
            InitializeComponent();
            control = main;
        }

        /// <summary>
        /// Gets users ListView
        /// </summary>
        public ListView UsersList
        {
            get
            {
                return usersListView;
            }
        }

        /// <summary>
        /// Gets requests ListView
        /// </summary>
        public ListView ReqsList
        {
            get
            {
                return requestsListView;
            }
        }

        /// <summary>
        /// Happens when mouse click on users list view
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void UsersListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point pt = this.usersListView.PointToScreen(e.Location);
                this.usersContextMenuStrip.Show(pt);
            }
        }

        /// <summary>
        /// Happens when mouse clicked on requestsLisiView
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void RequestsListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point pt = this.requestsListView.PointToScreen(e.Location);
                this.requestsContextMenuStrip.Show(pt);
            }
        }

        /// <summary>
        /// load admin view
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void AdminView_Load(object sender, EventArgs e)
        {
            control.LoadUsers();
            control.LoadRequests();
        }

        /// <summary>
        /// Changes user's status to Manager
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void ManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem x in this.usersListView.Items)
            {
                if (x.Selected)
                {
                    this.control.ChangeUserStatus("Manager", x.Text);
                }
            }
            //refresh
            this.control.LoadUsers();
        }

        /// <summary>
        /// Changes user's status to Supervisor
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void SupervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem x in this.usersListView.Items)
            {
                if (x.Selected)
                {
                    this.control.ChangeUserStatus("Supervisor", x.Text);
                }
            }
            //refresh
            this.control.LoadUsers();
        }

        /// <summary>
        /// Changes user's status to LoggedUser
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void LoggedUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem x in this.usersListView.Items)
            {
                if (x.Selected)
                {
                    this.control.ChangeUserStatus("LoggedUser", x.Text);
                }
            }
            //refresh
            this.control.LoadUsers();
        }

        /// <summary>
        /// Happens when Accept tool strip menu item is clicked
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void AcceptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem x in this.requestsListView.Items)
            {
                if (x.Selected)
                {
                    this.control.AcceptUser(x.Text);
                }
            }

            this.control.LoadRequests();
            this.control.LoadUsers();
        }

        /// <summary>
        /// Happens when Reject tool strip menu item is clicked
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void RejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem x in this.requestsListView.Items)
            {
                if (x.Selected)
                {
                    this.control.RejectUser(x.Text);
                }
            }

            this.control.LoadRequests();
        }

        /// <summary>
        /// Happens when Delete tool strip menu item is clicked
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem x in this.usersListView.Items)
            {
                if (x.Selected)
                {
                    control.DeleteUser(x.Text);
                }
            }

            this.control.LoadUsers();
        }
    }
}
