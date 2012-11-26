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
    /// <summary>
    /// Class HostForCardPayment
    /// </summary>
    public partial class HostForCardPayment : UserControl
    {
        /// <summary>
        /// main controler
        /// </summary>
        private MainController control;

        /// <summary>
        /// Initializes a new instance of the <see cref="HostForCardPayment"/> class.
        /// </summary>
        /// <param name="ctrl">main controler</param>
        public HostForCardPayment(MainController ctrl)
        {
            control = ctrl;
            InitializeComponent();
        }
    }
}
