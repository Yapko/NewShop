﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Shop
{
    /// <summary>
    /// Controller class of our program
    /// </summary>
    public class Control
    {
        /// <summary>
        /// mvc view for this controller
        /// </summary>
        private Form1 view;

        /// <summary>
        /// mvc model for this controller
        /// </summary>
        private Model model;

        /// <summary>
        /// Initializes a new instance of the <see cref="Control"/> class.
        /// </summary>
        public Control()
        {
            view = new Form1(this);
            model = null;
        }
       
        /// <summary>
        /// Run controller
        /// </summary>
        public void Run()
        {
            Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(view);
        }

        /// <summary>
        /// Show message to user
        /// </summary>
        public void ShowMessage()
        {
            view.ShowMessage("Hello Yapko)!");
        }
    }
}
