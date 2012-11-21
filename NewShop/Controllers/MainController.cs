﻿using System;
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
        /// list of products that current user adds
        /// to his busked
        /// </summary>
        private List<Product> userProducts;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainController"/> class.
        /// </summary>
        public MainController()
        {
            userProducts = new List<Product>();
            view = new MainWnd(this);
            user = new User();
            user.Status = "Unlogged";
            LoadLogin();
            ChangeUser();
            LoadProductsList();
            //initialization
            //List<Product> pr = new List<Product>();
            //pr = repos.GetAllProducts();
            //Image guitar = Image.FromFile("D:/127px-Guitar_1.jpg");
            //Image laptop = Image.FromFile("D:/asus-k25f-laptop.jpg");
            //Image iphone = Image.FromFile("D:/iphone5new2.jpg");
            //pr[0].SetImage(guitar);
            //pr[1].SetImage(laptop);
            //pr[2].SetImage(iphone);
            //repos.DeleteAllProducts();
            //repos.AddProducts(pr);
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
        
        #region Login

        /// <summary>
        /// Function fot login to system
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="pass">password</param>
        /// <param name="captchaStat">captcha status</param>
        public void LogIn(string username, string pass, bool captchaStat)
        {
            bool login = false;
            if (repos.HaveUser(username) == true)
            {
                if (repos.GetUser(username).Password == pass && captchaStat == true)
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
            if (user.Status == "Manager")
            {
                LoadManager();
            }
            else
            {
                DestroyManager();
            }
        }

        /// <summary>
        /// Loads login form
        /// </summary>
        public void LoadLogin()
        {
            view.LoadLogin(new Point(view.Width - 370, 60));
        }

        /// <summary>
        /// Loads manager form
        /// </summary>
        public void LoadManager()
        {
            view.LoadManager(new Point(view.Width - 370, 360));
        }

        /// <summary>
        /// Destroyes manager window
        /// </summary>
        public void DestroyManager()
        {
            view.ManagerDestroy();
        }

        /// <summary>
        /// Function to load user view
        /// </summary>
        public void LoadUserView()
        {
            view.LoadUserView(new Point(view.Width - 370, 60), user.UserName, user.Status);
        }

        /// <summary>
        /// Function to Destroy user view
        /// </summary>
        public void DestroyUserView()
        {
            view.DestroyUserView();
        }
        #endregion

        #region Registration
        /// <summary>
        /// ShowRegisterView form
        /// </summary>
        public void ShowRegisterView()
        {
            view.LoadRegister(new Point(view.Width - 550, 60));
        }

        /// <summary>
        /// registration of user
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="name1">first name</param>
        /// <param name="name2">last name</param>
        /// <param name="phone">phone number</param>
        /// <param name="email">email address</param>
        /// <param name="pass1">password</param>
        /// <param name="pass2">confirmed password</param>
        /// <param name="status">captcha status</param>
        public void Registration(string username, string name1, string name2, string phone, string email, string pass1, string pass2, bool status)
        {
            if (username.Length == 0 || !this.ValidateEmail(email) || !this.ValidatePassword(pass1) || !this.ValidateConfirmedPassword(pass1, pass2) || !status)
            {
                MessageBox.Show("Some data is wrong!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            User newUser = new User(username, name1, name2, email, pass1, phone, "none", "none", "none", "none", "UnloggedUser");
            repos.AddUser(newUser);
            MessageBox.Show("Your request will be considered as soon as posible!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        /// <summary>
        /// destroys register view
        /// </summary>
        public void DestroyRegisterView()
        {
            view.DestroyRegisterView();
        }

        #endregion

        /// <summary>
        /// Function to show user personal cabinet
        /// </summary>
        public void ShowPersonalCabinet()
        {
            DestroyProductsList();
            view.LoadAccount(new Point(60, 60), user);
        }

        /// <summary>
        /// Destroy personal account
        /// </summary>
        public void DestroyPersonalCabinet()
        {
            view.DestroyAccount();
            LoadProductsList();
        }

        /// <summary>
        /// destroy products list
        /// </summary>
        public void DestroyProductsList()
        {
            view.DestroyProductsList();
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
        /// emails validating
        /// </summary>
        /// <param name="email">email text</param>
        /// <returns>bool</returns>
        public bool ValidateEmail(string email)
        {
            bool val = email.Contains('@') && email.Contains('.')
                && (email.Length - email.LastIndexOf('.') == 3
                || email.Length - email.LastIndexOf('.') == 4);
            return val;
        }

        /// <summary>
        /// password validation
        /// </summary>
        /// <param name="pass">password</param>
        /// <returns>bool</returns>      
        public bool ValidatePassword(string pass)
        {
            bool valid = true;
            if (pass.Length < 8)
            {
                valid = false;
            }
            else
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(pass, @"\d"))
                {
                    valid = false;
                }
            }

            return valid;
        }

        /// <summary>
        /// validating confirmed password
        /// </summary>
        /// <param name="pass1">password</param>
        /// <param name="pass2">confirmed password</param>
        /// <returns>bool</returns>
        public bool ValidateConfirmedPassword(string pass1, string pass2)
        {
            bool valid = true;
            if (pass1.Length < pass2.Length)
            {
                valid = false;
            }
            else
            {
                for (int i = 0; i < pass2.Length; i++)
                {
                    if (pass1[i] != pass2[i])
                    {
                        valid = false;
                    }
                }
            }

            return valid;
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
            isOk = VerifyPassword(oldPass, newPass, newPass2);
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

        /// <summary>
        /// add a product to user basked
        /// </summary>
        /// <param name="toAdd">product to add</param>
        public void AddToUserBasked(Product toAdd)
        {
            userProducts.Add(toAdd);
        }

        /// <summary>
        /// loads user basked to main form
        /// </summary>
        public void LoadUserProductsList()
        {
            view.LoadUserProductsList(userProducts);
        }

        /// <summary>
        /// removes user basked from main form
        /// </summary>
        public void DestroyUserProductsList()
        {
            view.DestroyUserProductsList();
        }

        /// <summary>
        /// removes all products from user basked
        /// </summary>
        public void ClearUserBasked()
        {
            userProducts.Clear();
        }

        /// <summary>
        /// Gets focused product from list
        /// </summary>
        /// <returns> selected product </returns>
        public Product GetSelectedProduct()
        {
            return view.GetSelectedProduct();
        }

        public  void DeleteSelectedProduct()
        {
            Product prod = GetSelectedProduct();
            if (prod != null)
            {
                repos.DeleteProduct(prod);
            }
            //else
            //{
            //    MessageBox.Show("Nothing to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}
