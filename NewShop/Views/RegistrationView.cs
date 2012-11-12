using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Shop.AppData;
using Shop.Controllers;
using Shop.Models;

namespace Shop.Views
{
    /// <summary>
    /// Registration form
    /// </summary>
    public partial class RegistrationView : UserControl
    {
        /// <summary>
        /// Main controller
        /// </summary>
        private MainController control;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationView"/> class.
        /// </summary>
        /// <param name="m">control</param>
        public RegistrationView(MainController m)
        {
            InitializeComponent();
            control = m;
        }
    }
}
