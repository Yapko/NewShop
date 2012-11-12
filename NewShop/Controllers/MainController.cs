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
            user.Status = "Unlogged";
            LoadLogin();
            ChangeUser();
            //LoadProductsList();
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
                    LoadUserView();
                    login = true;
                }
            }

            if (!login)
            {
                MessageBox.Show("Loginning fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ChangeUser();
        }

        /// <summary>
        /// function to loggin out
        /// </summary>
        public void LogOut()
        {
            user = new User();
            user.Status = "Unlogged";
            DestroyUserView();
            LoadLogin();
            ChangeUser();
        }

        /// <summary>
        /// Destroyes login window
        /// </summary>
        public void DestroyLogin()
        {
            view.LoginDestroy();
        }

        /// <summary>
        /// Forms changes on changing user
        /// </summary>
        public void ChangeUser()
        {
            //TODO: Check and change controls needed to current user.
        }

        /// <summary>
        /// Loads login form
        /// </summary>
        public void LoadLogin()
        {
            view.LoadLogin(new Point(view.Width - 350, 60));
        }

        /// <summary>
        /// Function to load user view
        /// </summary>
        public void LoadUserView()
        {
            view.LoadUserView(new Point(view.Width - 350, 60), user.UserName, user.Status);
        }

        /// <summary>
        /// Function to Destroy user view
        /// </summary>
        public void DestroyUserView()
        {
            view.DestroyUserView();
        }
        #endregion

        /// <summary>
        /// Register form
        /// </summary>
        public void Register()
        {
            //TODO: Make registration!
            MessageBox.Show("TODO: Make registration!", "Issue", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        /// <summary>
        /// Function to show user personal cabinet
        /// </summary>
        public void ShowPersonalCabinet()
        {
            view.LoadAccount(new Point(60, 60), user);
        }

        /// <summary>
        /// Destroy personal account
        /// </summary>
        public void DestroyPersonalCabinet()
        {
            view.DestroyAccount();
        }

        /// <summary>
        /// функція, яка перевіряє чи співпадає пароль
        /// </summary>
        /// <param name="oldPass">old password</param>
        /// <param name="newPass">new password text</param>
        /// <param name="newPass2">new password text verifying</param>
        /// <returns>or password validated</returns>
        public bool VerifyPassword(string oldPass, string newPass, string newPass2)
        {
            bool truth = false;
            if ((oldPass != string.Empty) && (oldPass == user.Password) && (newPass == newPass2) && (newPass != string.Empty))
            {
                truth = true;
            }

            return truth;
        }
        
        /// <summary>
        /// email address validation
        /// </summary>
        /// <param name="emailField">e-mail texbox</param>
        /// <param name="err"> ErrorProvider</param>
        /// <returns>e-mail is valid</returns>
        public bool EmailAddressValidation(TextBox emailField, ErrorProvider err)
        {
            string email = emailField.Text;
            bool val = email.Contains('@') && email.Contains('.')
                && (email.Length - email.LastIndexOf('.') == 3
                || email.Length - email.LastIndexOf('.') == 4);
            if (val == false)
            {
                emailField.ForeColor = Color.Red;
                err.SetError(emailField, "your email is not correct!");
            }

            return val;
        }

        /// <summary>
        /// Save change user
        /// </summary>
        /// <param name="addres">address</param>
        /// <param name="firstName">first name</param>
        /// <param name="lastName">last name</param>
        /// <param name="country">country</param>
        /// <param name="postCode">postCode</param>
        /// <param name="gender">gender</param>
        /// <param name="email">e-mail</param>
        /// <param name="tel">phone</param>
        /// <param name="username">username</param>
        /// <param name="oldPass">old password</param>
        /// <param name="newPass">new password</param>
        /// <param name="newPass2">new password verifying</param>
        /// <returns>or changed account</returns>
        public bool SaveChangeAccount(string addres, string firstName, string lastName, string country, string postCode, string gender, string email, string tel, string username, string oldPass, string newPass, string newPass2)
        {
            bool isOk = true;
            isOk = VerifyPassword(oldPass, newPass, newPass2) /*&& EmailAddressValidation(_email, _getErrProvider1())*/;
            if (oldPass == string.Empty)
            {
                newPass = user.Password;
            }
            else if (!isOk)
            {
                view.ShowMessage("Some data is wrong!");
                return false;
            }

            User temp = new User();
            temp.Country = country;
            temp.ZipCode = postCode;
            temp.Gender = gender;
            temp.Email = email;
            temp.Phone = tel;
            temp.UserName = username;
            temp.Password = newPass;
            temp.Status = user.Status;
            temp.FirstName = firstName;
            temp.LastName = lastName;
            temp.Adress = addres;
            repos.DeleteUser(user);
            if (repos.HaveUser(user.UserName))
            {
                view.ShowMessage("Something goes wrong!");
            }
            else
            {
                repos.AddUser(temp);
            }

            user = repos.GetUser(temp.UserName);
            ChangeUser();
            return true;
        }

        /// <summary>
        /// load product list to main form
        /// </summary>
        public void LoadProductsList()
        {
            view.LoadProductsList(repos.GetAllProducts());
        }

       
    }
}
