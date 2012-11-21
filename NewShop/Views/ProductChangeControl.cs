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
        /// Gets copy of product before change
        /// </summary>
        public Product OldProd
        {
            get { return oldProd; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductChangeControl"/> class.
        /// </summary>
        /// <param name="ctrl"> main conctroller </param>
        public ProductChangeControl(MainController ctrl)
        {
            InitializeComponent();
            control = ctrl;
        }

        /// <summary>
        /// Gets or sets a value indicating whether changed product
        /// </summary>
        public Product ChangedProduct 
        {
            get
            {
                return new Product();
            }
            set
            {
                oldProd = value;
                //fields initialization
            }
        }

        private void SetImageToPanel(Image img)
        {
            Graphics grf = imgPanel.CreateGraphics();
            PointF[] points = {new PointF(0,0),new PointF(0,imgPanel.Width), new PointF(imgPanel.Height,imgPanel.Width), new PointF(imgPanel.Height,0)};
            grf.DrawImage(img, points);
        }
    }
}
