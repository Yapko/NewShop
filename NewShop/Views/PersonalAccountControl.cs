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
    /// Control for personal account
    /// </summary>
    public partial class PersonalAccountControl : UserControl
    {

        /// <summary>
        /// Main controller
        /// </summary>
        private MainController main;

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalAccountControl"/> class.
        /// </summary>
        public PersonalAccountControl(MainController a)
        {
            InitializeComponent();
            main = a;
        }

        /// <summary>
        /// Save changes
        /// </summary>
        /// <param name="sender"> message sender </param>
        /// <param name="e"> event </param>
        private void Save_Click(object sender, EventArgs e)
        {
            main.SaveChangeAccount(addressTxt.Text, firstNameTxt.Text, lastNameTxt.Text, countryTxt.Text, postCodeTxt.Text, genderTxt.Text, emailTxt.Text, telTxt.Text, usernameTxt.Text, oldPassTxt.Text, newPassTxt.Text, newPass2Txt.Text);
        }

        /// <summary>
        /// set address
        /// </summary>
        public string SetAddreess
        {
            set { addressTxt.Text = value; }
        }

        /// <summary>
        /// PersonalAccountControl_Load
        /// </summary>
        /// <param name="sender">message sender</param>
        /// <param name="e">event</param>
        private void PersonalAccountControl_Load(object sender, EventArgs e)
        {
            
            main.LoadAccount(addressTxt.Text, firstNameTxt.Text, lastNameTxt.Text, countryTxt.Text, postCodeTxt.Text, genderTxt.Text, emailTxt.Text, telTxt.Text, usernameTxt.Text, oldPassTxt.Text, newPassTxt.Text, newPass2Txt.Text);
        }
    }
}
