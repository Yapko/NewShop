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
            button2.Enabled = false;
            captcha.MakeCaptcha();
            captcha.ShowCaptcha();
        }

        /// <summary>
        /// Method running when form redraws.
        /// </summary>
        /// <param name="sender"> Sender of a message.</param>
        /// <param name="e"> Arguments.</param>
        private void SingleCapthca_Paint(object sender, PaintEventArgs e)
        {
            captcha.ShowCaptcha();
        }

        /// <summary>
        /// Method running when checked button refresh.
        /// </summary>
        /// <param name="sender"> sender of a message.</param>
        /// <param name="e"> Arguments.</param>
        private void Button2_Click(object sender, EventArgs e)
        {
            captcha.Refresh();
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
            }
            else
            {
                errorProvider1.SetError(textBox1, "Wrong");
            }
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
    }
}
