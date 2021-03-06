﻿using System;
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
        /// Gets or sets a value indicating whether product button enabled
        /// </summary>
        public bool ProductsButton
        {
            get { return ProductsListBtn.Enabled; }
            set { ProductsListBtn.Enabled = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether basket button enabled
        /// </summary>
        public bool BasketButton
        {
            get { return OpenBasketBtn.Enabled; }
            set { OpenBasketBtn.Enabled = value; }
        }
        
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
            ProductsListBtn.Enabled = false;
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

        /// <summary>
        /// open used basket and close product list
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void OpenBasketBtn_Click(object sender, EventArgs e)
        {
            control.DestroyProductsList();
            control.LoadUserProductsList();
            control.DestroyPersonalCabinet();
            ProductsListBtn.Enabled = true;
            OpenBasketBtn.Enabled = false;
        }

        /// <summary>
        /// open products list and close user basket
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void ProductsListBtn_Click(object sender, EventArgs e)
        {
            control.DestroyUserProductsList();
            control.LoadProductsList();
            control.DestroyPersonalCabinet();
            ProductsListBtn.Enabled = false;
            OpenBasketBtn.Enabled = true;
        }

        /// <summary>
        /// open card paymayment
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void BuyBtn_Click(object sender, EventArgs e)
        {
            control.LoadPayment();
        }
    }
}
