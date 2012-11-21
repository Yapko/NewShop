using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shop.AppData;
using Shop.Controllers;

namespace Shop.Views
{
    /// <summary>
    /// Form for manager
    /// </summary>
    public partial class ManagerControl : UserControl
    {
        /// <summary>
        /// main controller
        /// </summary>
        private MainController control;

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerControl"/> class.
        /// </summary>
        /// <param name="ctrl">main controller</param>
        public ManagerControl(MainController ctrl)
        {
            InitializeComponent();
            control = ctrl;
        }

        /// <summary>
        /// Button add clicked
        /// </summary>
        /// <param name="sender"> message sender</param>
        /// <param name="e"> event </param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Add button was clicked", "Captain Obvious");
        }

        /// <summary>
        /// Button change clicked
        /// </summary>
        /// <param name="sender"> message sender</param>
        /// <param name="e"> event </param>
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Change button was clicked", "Captain Obvious");
        }

        /// <summary>
        /// Button delete clicked
        /// </summary>
        /// <param name="sender"> message sender</param>
        /// <param name="e"> event </param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this, "Delete button was clicked", "Captain Obvious");
            control.DeleteSelectedProduct();
        }
    }
}
