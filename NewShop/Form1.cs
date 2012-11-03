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
            PictureBox ClosePictureBox = new PictureBox();
            ClosePictureBox.Location = new Point(this.Width - 25, 10);
            ClosePictureBox.Image = Properties.Resources.CloseButton;
            ClosePictureBox.Click += closePricure_Click;
            this.Controls.Add(ClosePictureBox);
        }
    }
}
