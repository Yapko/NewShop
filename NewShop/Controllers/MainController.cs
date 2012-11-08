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
        /// <summary>
        /// Instance of our repository
        /// </summary>
        private Repository repos = Repository.Instance;

        /// <summary>
        /// mvc view for this controller
        /// </summary>
        private MainWnd view;

        /// <summary>
        /// this user
        /// </summary>
        private User user;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainController"/> class.
        /// </summary>
        public MainController()
        {
            view = new MainWnd(this);
            user = new User();
            LoadLogin();
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
        /// Shows message
        /// </summary>
        /// <param name="message">message to show</param>
        public void ShowMessage(string message)
        {
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

        /// <summary>
        /// Function fot login to system
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="pass">password</param>
        public void LogIn(string username, string pass)
        {
            bool login = false;
            if (repos.HaveUser(username) == true)
            {
                if (repos.GetUser(username).Password == pass)
                {
                    user = repos.GetUser(username);
                    DestroyLogin();
                    MessageBox.Show("You are logged successfuly", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    login = true;
                }
            }
            if (!login)
            {
                MessageBox.Show("Loginning fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Destroyes login window
        /// </summary>
        public void DestroyLogin()
        {
            view.LoginDestroy();
        }

        /// <summary>
        /// Loads login form
        /// </summary>
        public void LoadLogin()
        {
            view.LoadLogin(new Point(view.Width / 2 - 30, view.Height / 2 - 30));
        }

        #endregion
    }
}
