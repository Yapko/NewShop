using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shop.Models;

namespace Shop.Views
{
    /// <summary>
    /// Form for single draw and check captcha.
    /// </summary>
    public partial class CaptchaControl : UserControl
    {
        /// <summary>
        /// captcha to show and check at window.
        /// </summary>
        private Captcha captcha;

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptchaControl"/> class.
        /// </summary>
        public CaptchaControl()
        {
            InitializeComponent();
            captcha = new Captcha(panel1);
            captcha.MakeCaptcha();
            captcha.ShowCaptcha();
            errorProvider1.SetError(textBox1, "Wrong");
            // creating tooltip for close icon
            ToolTip refresh = new ToolTip();
            refresh.ShowAlways = true;
            refresh.SetToolTip(panel1, "Click to refresh");  
        }

        /// <summary>
        /// Gets a value indicating whether current status of captcha
        /// </summary>
        public bool Check
        {
            get
            {
                return captcha.Validate(textBox1.Text);
            }
        }

        /// <summary>
        /// Method running when user inputs text.
        /// </summary>
        /// <param name="sender"> sender of a message.</param>
        /// <param name="e"> Arguments.</param>
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (captcha.Validate(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, string.Empty);
                errorProvider2.SetError(textBox1, "Ok");
                captcha.ShowCaptcha();
            }
            else
            {
                errorProvider1.SetError(textBox1, "Wrong");
                errorProvider2.SetError(textBox1, string.Empty);
            }
        }

        /// <summary>
        /// Method running when form redraws.
        /// </summary>
        /// <param name="sender"> Sender of a message.</param>
        /// <param name="e"> Arguments.</param>
        private void CaptchaControl_Paint(object sender, PaintEventArgs e)
        {
            captcha.ShowCaptcha();
        }

        /// <summary>
        /// Method running when panel redraws
        /// </summary>
        /// <param name="sender">Sender of a message.</param>
        /// <param name="e">Arguments.</param>
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            captcha.ShowCaptcha();
        }

        /// <summary>
        /// Method running when user clack to panel
        /// </summary>
        /// <param name="sender">Sender of a message.</param>
        /// <param name="e">Arguments.</param>
        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.ResetText();
            captcha.Refresh();
        }
    }
}
