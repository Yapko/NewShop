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
    partial class Form1 : Form
    {
        private Control control;

        public Form1(Control newControl)
        {
            InitializeComponent();
            control = newControl;
        }

        public void showMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void closePricure_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //to create close icon
            LoadCloseIcon();
        }

        /// <summary>
        /// create close icon in main form
        /// </summary>
        private void LoadCloseIcon()
        {
            //create picturebox for icon
            PictureBox ClosePictureBox = new PictureBox();
            //set location in right upper corner
            ClosePictureBox.Location = new Point(this.Width - 25, 10);
            //set icon
            ClosePictureBox.Image = Properties.Resources.GreyCloseIcon;
            //set event 
            ClosePictureBox.Click += closePricure_Click;

            //creating tooltip for close icon
            ToolTip ClosePictureBoxToolTip = new ToolTip();
            ClosePictureBoxToolTip.ShowAlways = true;           
            ClosePictureBoxToolTip.SetToolTip(ClosePictureBox, "close");  
          
            //add complete picture box to mainform controls
            this.Controls.Add(ClosePictureBox);
        }
    }
}
