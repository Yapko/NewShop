using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Shop.Views;
using Shop.AppData;
using Shop.Models;

namespace Shop.Controllers
{
    /// <summary>
    /// Controller class of our program
    /// </summary>
    public class MainController
    {
        Repository repos = Repository.Instance;

        /// <summary>
        /// mvc view for this controller
        /// </summary>
        private MainWnd view;

        /// <summary>
        /// mvc model for this controller
        /// </summary>
        // private Model model;

        /// <summary>
        /// this user
        /// </summary>
        private User user;

        /// <summary>
        /// login window class
        /// </summary>
        private LoginControl login;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainController"/> class.
        /// </summary>
        public MainController()
        {
            view = new MainWnd(this);
            user = new User();
            login = new LoginControl(this);
        //    model = null;
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
        public void ShowMessage(string message)
        {
            //
            view.ShowMessage(message);
        }
        #region Captcha
        /// <summary>
        /// Shows captcha at current location
        /// </summary>
        /// <param name="where">point where to show it</param>
        public void ShowCaptcha(Point where)
        {
            view.LoadCaptcha(where);
        }

        /// <summary>
        /// Destroys captcha control
        /// </summary>
        public void DestroyCaptcha()
        {
            view.CaptchaDestroy();
        }

        /// <summary>
        /// Gets current status of captcha
        /// </summary>
        /// <returns>if captcha is correct</returns>
        public bool StatusCaptcha()
        {
            return view.CaptchaStatus();
        }
        #endregion
        
        #region Login
        public void SetStatusLogin(bool k)
        {
            view.SetLoginStatus(k);
            user = login.MyUser();
        }

        #endregion
    }
}
