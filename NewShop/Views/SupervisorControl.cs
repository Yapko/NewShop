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
    /// Form for supervisor
    /// </summary>
    public partial class SupervisorControl : UserControl
    {
        /// <summary>
        /// main controller
        /// </summary>
        private MainController control;

        /// <summary>
        /// Initializes a new instance of the <see cref="SupervisorControl"/> class.
        /// </summary>
        /// <param name="ctrl">main controller</param>
        public SupervisorControl(MainController ctrl)
        {
            InitializeComponent();
            control = ctrl;
            closeBtn.Enabled = false;
        }

        /// <summary>
        /// method loads list of Order with status "Pending"
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void LoadBtn_Click(object sender, EventArgs e)
        {            
            control.DestroyProductsList();
            //control.DestroyUserProductsList();
            control.LoadOrderList();
            loadBtn.Enabled = false;
            closeBtn.Enabled = true;
        }

        /// <summary>
        /// method close list of Orders
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            control.DestroyOrderList();           
            control.LoadProductsList();
            loadBtn.Enabled = true;
            closeBtn.Enabled = false;
        }
    }
}
