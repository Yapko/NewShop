using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shop.Controllers;

namespace Shop.Views
{
    public partial class HostForCardPayment : UserControl
    {
        private MainController control;

        public HostForCardPayment(MainController ctrl)
        {
            control = ctrl;
            InitializeComponent();
        }
    }
}
