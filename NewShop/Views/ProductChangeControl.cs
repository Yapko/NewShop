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
    /// Class for change product properties
    /// </summary>
    public partial class ProductChangeControl : UserControl
    {
        /// <summary>
        /// Main controller
        /// </summary>
        private MainController control;

        /// <summary>
        /// Product before change
        /// </summary>
        private Product oldProd;

        /// <summary>
        /// Gets or sets copy of product before change
        /// </summary>
        public Product OldProd
        {
            get { return oldProd; }
            set { oldProd = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductChangeControl"/> class.
        /// </summary>
        /// <param name="ctrl"> main conctroller </param>
        public ProductChangeControl(MainController ctrl)
        {
            InitializeComponent();
            control = ctrl;
            oldProd = null;
            //add initialization
            NameTxt.Text = "noname";
            DescriptionTxt.Text = string.Empty;
            ManufacturerTxt.Text = string.Empty;
            PriceTxt.Text = 0.ToString();
            pictureBox.Image = Properties.Resources.no_photo;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        /// <summary>
        /// Gets or sets a value indicating whether changed product
        /// </summary>
        public Product ChangedProduct 
        {
            get
            {
                return new Product(pictureBox.Image, NameTxt.Text, DescriptionTxt.Text, ManufacturerTxt.Text, double.Parse(PriceTxt.Text));
            }

            set
            {
                oldProd = value;
                NameTxt.Text = value.Name;
                DescriptionTxt.Text = value.Describe;
                ManufacturerTxt.Text = value.Maufacture;
                PriceTxt.Text = value.Price.ToString();
                pictureBox.Image = value.GetImage();
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        /// <summary>
        /// Save changes at eddited product
        /// </summary>
        /// <param name="sender"> message sender </param>
        /// <param name="e"> event </param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (oldProd != null)
            {
                control.ChangeProduct(oldProd, ChangedProduct);
            }
            else
            {
                control.AddNewProduct(ChangedProduct);
            }

            control.DestroyProductChange();
        }

        /// <summary>
        /// Cancel changes at eddited product
        /// </summary>
        /// <param name="sender"> message sender </param>
        /// <param name="e"> event </param>
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            control.DestroyProductChange();
        }

        /// <summary>
        /// Check name after change
        /// </summary>
        /// <param name="sender"> message sender </param>
        /// <param name="e"> event </param>
        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            if (NameTxt.Text.Length == 0)
            {
                SaveBtn.Enabled = false;
            }
            else
            {
                SaveBtn.Enabled = true;
            }
        }

        /// <summary>
        /// Load new image to eddited product
        /// </summary>
        /// <param name="sender"> message sender </param>
        /// <param name="e"> event </param>
        private void ChangeImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(open.FileName);
                pictureBox.Image = img;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
