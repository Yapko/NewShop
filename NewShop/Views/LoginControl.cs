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

        private int attempts;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginControl"/> class.
        /// </summary>
        /// <param name="a">instance of comtroller</param>
        public LoginControl(MainController a)
        {
            InitializeComponent();
            main = a;
            attempts = 0;
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
            ++attempts;
            bool captcha = true;
            if (Controls.ContainsKey("CaptchaControl") == true)
            {
                captcha = CaptchaStatus();
                if (captcha == true)
                {
                    attempts = 0;
                }
            }
            main.LogIn(UsernameTxt.Text, PasswordTxt.Text, captcha);
            UsernameTxt.ResetText();
            PasswordTxt.ResetText();
            if(attempts >= 5)
            {
                LoadCaptcha(new Point(60,120));
                this.Height = 271;
            }
            else
            {
                CaptchaDestroy();
                this.Height = 171;
            }
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
            main.ShowRegisterView();
            main.DestroyProductsList();           
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
            return ((CaptchaControl) Controls[Controls.IndexOfKey("CaptchaControl")]).Check;
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
    }
}
