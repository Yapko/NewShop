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

    }
}
