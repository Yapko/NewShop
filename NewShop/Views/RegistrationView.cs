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
    /// Registration form
    /// </summary>
    public partial class RegistrationView : UserControl
    {
        /// <summary>
        /// Main controller
        /// </summary>
        private MainController control;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationView"/> class.
        /// </summary>
        /// <param name="m">control</param>
        public RegistrationView(MainController m)
        {
            InitializeComponent();
            control = m;
            LoadCaptcha(new Point(163, 325));
        }

        /// <summary>
        /// Create captcha in main form
        /// </summary>
        /// <param name="position">position of upper left ungle </param>
        public void LoadCaptcha(Point position)
        {
            //create captcha
            CaptchaControl captcha = new CaptchaControl();
            // set location in center of form
            captcha.Location = position;

            // add complete picture box to mainform controls
            this.Controls.Add(captcha);
        }

        /// <summary>
        /// Gets current status of Captcha
        /// </summary>
        /// <returns>if text equivalent to captcha</returns>
        public bool CaptchaStatus()
        {
            return ((CaptchaControl)Controls[Controls.IndexOfKey("CaptchaControl")]).Check;
        }

        /// <summary>
        /// Destroys captcha
        /// </summary>
        public void CaptchaDestroy()
        {
            if (Controls.ContainsKey("CaptchaControl") == true)
            {
                Controls[Controls.IndexOfKey("CaptchaControl")].Dispose();
            }
        }

        /// <summary>
        /// registration happens
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event</param>
        private void button1_Click(object sender, EventArgs e)
        {
            control.DestroyRegisterView();
        }

        /// <summary>
        /// email validating
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event</param>
        private void emailField_Validating(object sender, CancelEventArgs e)
        {
            if (!control.ValidateEmail(emailField.Text))
            {
                e.Cancel = true;
                emailField.ForeColor = Color.Red;
                errorProvider1.SetError(emailField, "your email is not correct!");
            }
        }

        /// <summary>
        /// email is validated
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event</param>
        private void emailField_Validated(object sender, EventArgs e)
        {
            emailField.ForeColor = Color.Black;
            errorProvider1.SetError(emailField, string.Empty);
        }

        private void pass1Field_Validating(object sender, CancelEventArgs e)
        {
            if (!control.ValidatePassword(pass1Field.Text))
            {
                errorProvider1.SetError(pass1Field, "your password must have more than 8 symbols and contain some numbers!");
                pass1Field.ForeColor = Color.Red;
            }
        }

        private void pass1Field_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(pass1Field, string.Empty);
            pass1Field.ForeColor = Color.Black;
        }
    }
}
