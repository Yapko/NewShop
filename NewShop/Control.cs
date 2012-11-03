using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Shop
{
    class Control
    {
        private Form1 view;
        private Model model;

        public Control()
        {
            view = new Form1(this);
            model = null;
        }
       
        public void run()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(view);
        }

        public void showMessage()
        {
            view.showMessage("Hello world)))!");
        }
    }
}
