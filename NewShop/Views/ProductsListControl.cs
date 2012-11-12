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
    /// form for products list
    /// </summary>
    public partial class ProductsListControl : UserControl
    {
        /// <summary>
        /// Main controller
        /// </summary>
        private MainController main;


        /// <summary>
        /// Initializes a new instance of the <see cref="LoginControl"/> class.
        /// </summary>
        /// <param name="a">instance of comtroller</param>
        /// <param name="prods">list of products to be added to view</param>
        public ProductsListControl(MainController a,List<Product> prods)
        {
            InitializeComponent();
            main = a;

            foreach (Product p in prods)
            {
                ListViewItem lvi = new ListViewItem(p.Name);
                lvi.SubItems.Add(p.Describe);
                lvi.SubItems.Add(p.Maufacture);
                lvi.SubItems.Add(p.Price.ToString() + "$");
                AddNewProduct(lvi);
            }
            
        }

        /// <summary>
        /// method to add new product to view
        /// </summary>
        /// <param name="lvi">product to be added</param>
        public void AddNewProduct(ListViewItem lvi)
        {
            ProductsList.Items.Add(lvi);
        }

    }
}
