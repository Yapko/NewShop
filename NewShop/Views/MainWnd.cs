using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shop.Controllers;

namespace Shop.Views
{
    /// <summary>
    /// Main form
    /// </summary>
    public partial class MainWnd : Form
    {
        /// <summary>
        /// Controll class of this view
        /// </summary>
        private MainController control;

        /// <summary>
        /// Dictionary with positions of controls in this.Controls 
        /// </summary>
        private Dictionary<string, int> controlsPos;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWnd"/> class.
        /// </summary>
        /// <param name="newControl">class witch controls this form</param>
        public MainWnd(MainController newControl)
        {
            InitializeComponent();
            control = newControl;
            controlsPos = new Dictionary<string, int>();
        }

        /// <summary>
        /// Shows message to user via messagebox
        /// </summary>
        /// <param name="message">message wich want to show</param>
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        /// <summary>
        /// method of closing picture
        /// </summary>
        /// <param name="sender">app sender</param>
        /// <param name="e">app param</param>
        private void ClosePricure_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method which load all data to form
        /// </summary>
        /// <param name="sender">app sender</param>
        /// <param name="e">app param</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // to create close icon
            LoadCloseIcon();
            LoadCaptcha(new Point(this.Width / 2, this.Height / 2));
        }

        /// <summary>
        /// Create close icon in main form
        /// </summary>
        private void LoadCloseIcon()
        {
            // create picturebox for icon
            PictureBox closePictureBox = new PictureBox();
            // set location in right upper corner
            closePictureBox.Location = new Point(this.Width - 30, 10);
            // set icon
            closePictureBox.Image = Properties.Resources.GreyCloseIcon;
            // set event 
            closePictureBox.Click += ClosePricure_Click;

            // creating tooltip for close icon
            ToolTip closePictureBoxToolTip = new ToolTip();
            closePictureBoxToolTip.ShowAlways = true;           
            closePictureBoxToolTip.SetToolTip(closePictureBox, "Close");  
          
            // add complete picture box to mainform controls
            this.Controls.Add(closePictureBox);
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
            controlsPos.Add("Captcha", this.Controls.Count - 1);
        }

        /// <summary>
        /// Gets current status of Captcha
        /// </summary>
        /// <returns>if text equivalent to captcha</returns>
        public bool CaptchaStatus()
        {
            return ((CaptchaControl)Controls[Controls.Count - 1]).Check;;
        }

        /// <summary>
        /// Destroys captcha
        /// </summary>
        public void CaptchaDestroy()
        {
            this.Controls[controlsPos["Captcha"]].Dispose();
            //this.Controls.RemoveAt(controlsPos["Captcha"]);
        }
    }
}
