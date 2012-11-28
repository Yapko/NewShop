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
    /// form for order list
    /// </summary>
    public partial class OrdersControl : UserControl
    {
        /// <summary>
        /// main controller
        /// </summary>
        private MainController control;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersControl"/> class.
        /// </summary>
        /// <param name="ctrl">main controller</param>
       /// <param name="orders">orders</param>
        public OrdersControl(MainController ctrl, List<Order> orders)
        {
            InitializeComponent();
            control = ctrl;

            LoadOrders(orders);
        }

        /// <summary>
        /// loads orders to dataGridView
        /// </summary>
        /// <param name="orders">Orders</param>
        private void LoadOrders(List<Order> orders)
        {
            foreach (Order o in orders)
            {
                DataGridViewRow row = (DataGridViewRow)OrdersList.Rows[0].Clone();
                row.Cells[0].Value = o.CardNumber.ToString();
                row.Cells[1].Value = o.ID.ToString();
                row.Cells[2].Value = o.ProductID.ToString();
                row.Cells[3].Value = o.UserID.ToString();
                row.Cells[4].Value = o.ExpDate.ToString();
                row.Cells[5].Value = o.Date.ToString();
                row.Cells[6].Value = o.CVN.ToString();
                row.Cells[7].Value = o.Status.ToString();
                OrdersList.Rows.Add(row);
            }
        }

        /// <summary>
        /// change status of selected order
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void OrdersList_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in OrdersList.Rows)
            {
                if (row.Selected == true)
                {
                    if ((string)row.Cells[7].Value == "Pending")
                    {
                        //TODO: change status to "Accepted"
                        row.Cells[7].Value = "Accepted";
                        control.ChangeStatus(int.Parse((string)row.Cells[1].Value), "Accepted");
                    }
                    else
                    {
                        row.Cells[7].Value = "Pending";
                        control.ChangeStatus(int.Parse((string)row.Cells[1].Value), "Pending");
                    }
                }
            }
        }
    }
}
