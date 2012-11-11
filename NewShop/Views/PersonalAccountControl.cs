using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shop.Controllers;
using Shop.AppData;

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
        /// <param name="a">main controler</param>
        /// <param name="curr">this user</param>
        public PersonalAccountControl(MainController a, User curr)
        {
            InitializeComponent();
            firstNameTxt.Text = curr.FirstName;
            lastNameTxt.Text = curr.LastName;
            addressTxt.Text = curr.Adress;
            countryTxt.Text = curr.Country;
            postCodeTxt.Text = curr.ZipCode;
            genderTxt.Text = curr.Gender;
            emailTxt.Text = curr.Email;
            telTxt.Text = curr.Phone;
            usernameTxt.Text = curr.UserName;
            main = a;
        }

        /// <summary>
        /// Save changes
        /// </summary>
        /// <param name="sender"> message sender </param>
        /// <param name="e"> event </param>
        private void Save_Click(object sender, EventArgs e)
        {
            if (main.SaveChangeAccount(addressTxt.Text, firstNameTxt.Text, lastNameTxt.Text, countryTxt.Text, postCodeTxt.Text, genderTxt.Text, emailTxt.Text, telTxt.Text, usernameTxt.Text, oldPassTxt.Text, newPassTxt.Text, newPass2Txt.Text))
            {
                main.DestroyPersonalCabinet();
            }
        }

        /// <summary>
        /// Sets address
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
        }

        /// <summary>
        /// Cancel action personal cabinet
        /// </summary>
        /// <param name="sender">message sender</param>
        /// <param name="e">event</param>
        private void Cancel_Click(object sender, EventArgs e)
        {
            main.DestroyPersonalCabinet();
        }
    }
}
