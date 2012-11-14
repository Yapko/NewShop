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
            LoadCaptcha(new Point(163,325));
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void RegCloseBtn_Click(object sender, EventArgs e)
        {
            control.DestroyRegisterView();
            control.LoadProductsList();
            control.LoadLogin();
            CaptchaDestroy();
        }
    }
}
