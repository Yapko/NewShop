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
        /// Initializes a new instance of the <see cref="ProductsListControl"/> class.
        /// </summary>
        /// <param name="a">instance of comtroller</param>
        /// <param name="prods">list of products to be added to view</param>
        public ProductsListControl(MainController a, List<Product> prods)
        {
            InitializeComponent();
            main = a;           
            //creation of image lists
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();
            int imageIndex = 0;

            SetColumnsWidth();
            foreach (Product p in prods)
            {
                ListViewItem lvi = new ListViewItem(p.Name);
                
                lvi.SubItems.Add(p.Describe);
                lvi.SubItems.Add(p.Maufacture);
                lvi.SubItems.Add(p.Price.ToString() + "$");
                lvi.ImageIndex = imageIndex;
                imageIndex++;
                AddNewProduct(lvi);

                imageListSmall.Images.Add(p.GetImage());
                imageListLarge.Images.Add(p.GetImage());                
            }

            imageListLarge.ImageSize = new Size(200, 200);
            imageListSmall.ImageSize = new Size(150, 150);

            ProductsList.LargeImageList = imageListLarge;
            ProductsList.SmallImageList = imageListSmall;
        }

        /// <summary>
        /// method to add new product to view
        /// </summary>
        /// <param name="lvi">product to be added</param>
        public void AddNewProduct(ListViewItem lvi)
        {
            ProductsList.Items.Add(lvi);
        }

        /// <summary>
        /// set columns width
        /// width of every column is 30
        /// </summary>
        private void SetColumnsWidth()
        {
            ProductsList.Columns[0].Width = 400;
            ProductsList.Columns[1].Width = 200;
            ProductsList.Columns[2].Width = 100;
            ProductsList.Columns[3].Width = 100;
        }

        /// <summary>
        /// add checked product to user basked
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void ProductsList_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in ProductsList.Items)
            {
                if (lvi.Focused == true)
                {
                    string name = lvi.SubItems[0].Text;
                    string describe = lvi.SubItems[1].Text;
                    string manufacturer = lvi.SubItems[2].Text;
                    string price = lvi.SubItems[3].Text;
                    price = price.Remove(price.Length - 1);
                    double pr = double.Parse(price);

                    Image img = lvi.ImageList.Images[lvi.ImageIndex];
                    main.AddToUserBasked(new Product(img, name, describe, manufacturer, pr, 0));
                }
            }
        }
    }
}
