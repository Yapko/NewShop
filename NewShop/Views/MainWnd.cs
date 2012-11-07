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
            //only for testing
            //LoadCaptcha(new Point(this.Width / 2, this.Height / 2));

            //only for testing
            //create a login form
            LoadLoginForm(new Point(this.Width / 2, this.Height / 2));
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
        /// Create a login form in main form
        /// </summary>
        /// /// <param name="position">position of upper left ungle </param>
        private void LoadLoginForm(Point position)
        {
            LoginControl lc = new LoginControl(control);
            position.X -= lc.Width / 2;
            position.Y -= lc.Height / 2;
            lc.Location = position;
            this.Controls.Add(lc);
        }

        /// <summary>
        /// Gets current status of Captcha
        /// </summary>
        /// <returns>if text equivalent to captcha</returns>
        public bool CaptchaStatus()
        {
            return ((CaptchaControl)Controls[Controls.Count - 1]).Check;
        }

        /// <summary>
        /// Destroys captcha
        /// </summary>
        public void CaptchaDestroy()
        {
            this.Controls[controlsPos["Captcha"]].Dispose();
            //this.Controls.RemoveAt(controlsPos["Captcha"]);
        }
        /// <summary>
        /// Create login in main form
        /// </summary>
        /// <param name="position">position of upper left ungle </param>
      
        public void LoadLogin(Point position)
        {
            //create login
            LoginControl login = new LoginControl(control);
            // set location in center of form
            login.Location = position;

            // add login to mainform controls
            this.Controls.Add(login);
            controlsPos.Add("Login", this.Controls.Count - 1);
        }

        /// <summary>
        /// make button visible or unvisible
        /// </summary>
        /// <param name="b"> </param>
        public void SetLoginStatus(bool b)
        {
            //LoginBtn.Enabled = b;
        }
        /// <summary>
        /// Load login form
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        private void Login_Click(object sender, EventArgs e)
        {
            LoadLogin(new Point(2, 30));
        }

        /// <summary>
        /// Create account in main form
        /// </summary>
        /// <param name="position">position of upper left ungle </param>

        public void LoadAccount(Point position)
        {
            //create login
            PersonalAccountControl account = new PersonalAccountControl();
            // set location in center of form
            account.Location = position;

            // add login to mainform controls
            this.Controls.Add(account);
            controlsPos.Add("Personal account", this.Controls.Count - 1);
        }

        /// <summary>
        /// Load Personal account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountBtn_Click(object sender, EventArgs e)
        {
            LoadAccount(new Point(2, 30));
        }
    }
}
