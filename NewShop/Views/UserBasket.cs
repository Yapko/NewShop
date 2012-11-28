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
    /// form for users products list
    /// </summary>
    public partial class UserBasket : UserControl
    {
        /// <summary>
        /// Main controller
        /// </summary>
        private MainController main;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserBasket"/> class.
        /// </summary>
        /// <param name="a">main controller</param>
        /// <param name="prods">list of products to be shown</param>
        public UserBasket(MainController a, List<Product> prods)
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

            UserProductsList.LargeImageList = imageListLarge;
            UserProductsList.SmallImageList = imageListSmall;
        }

        /// <summary>
        /// set columns width
        /// </summary>
        private void SetColumnsWidth()
        {
            UserProductsList.Columns[0].Width = 400;
            UserProductsList.Columns[1].Width = 200;
            UserProductsList.Columns[2].Width = 100;
            UserProductsList.Columns[3].Width = 100;
        }

        /// <summary>
        /// add new item to listview
        /// </summary>
        /// <param name="lvi">item to add</param>
        public void AddNewProduct(ListViewItem lvi)
        {
            UserProductsList.Items.Add(lvi);
        }

        /// <summary>
        /// Get focused element from product list
        /// </summary>
        /// <returns> product wich focused </returns>
        public List<Product> GetFocused()
        {
            List<Product> toRet = new List<Product>();
            Product toAdd = null;
            foreach (ListViewItem lvi in UserProductsList.Items)
            {
                if (lvi.Focused == true)
                {
                    string price = lvi.SubItems[3].Text;
                    price = price.Remove(price.Length - 1);
                    double pr = double.Parse(price);
                    toAdd = new Product(lvi.ImageList.Images[lvi.ImageIndex], lvi.SubItems[0].Text, lvi.SubItems[1].Text, lvi.SubItems[2].Text, pr, UserProductsList.Items.IndexOf(lvi) + 1);
                    toRet.Add(toAdd);
                }
            }

            return toRet;
        }
    }    
}
