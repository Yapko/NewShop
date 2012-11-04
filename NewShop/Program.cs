using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Shop.Controllers;

namespace Shop
{
    /// <summary>
    /// Main program class which start our app
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            MainController c = new MainController();
            c.Run();
        }
    }
}
