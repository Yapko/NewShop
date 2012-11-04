using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shop
{
    /// <summary>
    /// Main form
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Controll class of this view
        /// </summary>
        private Control control;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        /// <param name="newControl">class witch controls this form</param>
        public Form1(Control newControl)
        {
            InitializeComponent();
            control = newControl;
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
            closePictureBoxToolTip.SetToolTip(closePictureBox, "close");  
          
            // add complete picture box to mainform controls
            this.Controls.Add(closePictureBox);
        }
    }
}
