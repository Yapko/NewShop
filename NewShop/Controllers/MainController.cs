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
            user.Status = "UnloggedUser";
            ChangeUser();
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
            user.Status = "UnloggedUser";
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
            DestroyLogin();
            DestroyManager();
            DestroyPersonalCabinet();
            DestroyProductsList();
            DestroyRegisterView();
            DestroyUserProductsList();
            DestroyUserView();
            switch (user.Status)
            {
                case "Manager":
                    LoadUserView();
                    LoadProductsList();
                    LoadManager();
                    break;
                case "Admin":
                    LoadUserView();
                    LoadProductsList();
                    LoadAdmin();
                    break;
                case "Supervisor":
                    LoadUserView();
                    LoadProductsList();
                    //TODO: Load Supervisor
                    break;
                case "LoggedUser":
                    LoadUserView();
                    LoadProductsList();
                    break;
                case "UnloggedUser":
                    LoadLogin();
                    LoadProductsList();
                    break;
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
        /// Loads payment form
        /// </summary>
        public void LoadPayment()
        {
            view.LoadPayment(new Point(view.Width - 370, 300));
        }

        /// <summary>
        /// Destroyes payment window
        /// </summary>
        public void DestroyPayment()
        {
            view.PaymentDestroy();
        }

        /// <summary>
        /// Loads manager form
        /// </summary>
        public void LoadManager()
        {
            view.LoadManager(new Point(view.Width - 370, 320));
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

        /// <summary>
        /// Loads admin's view
        /// </summary>
        public void LoadAdmin()
        {
            view.LoadAdmin(new Point(view.Width - 470, 320));
        }

        /// <summary>
        /// Destroyes admin's view
        /// </summary>
        public void DestroyAdmin()
        {
            view.AdminDestroy();
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

        #region PersonalCabinet

        /// <summary>
        /// Function to show user personal cabinet
        /// </summary>
        public void ShowPersonalCabinet()
        {
            DestroyProductsList();
            DestroyUserProductsList();
            view.SetUserViewBasketButton(true);
            view.SetUserViewProductsButton(true);
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

        #endregion

        /// <summary>
        /// destroy products list
        /// </summary>
        public void DestroyProductsList()
        {
            view.DestroyProductsList();
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

        /// <summary>
        /// Delete selected product from database
        /// </summary>
        public void DeleteSelectedProduct()
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
            RefreshProductList();
        }

        /// <summary>
        /// Refresh product list
        /// </summary>
        public void RefreshProductList()
        {
            //TODO: Rewrite refresh product list
            DestroyProductsList();
            LoadProductsList();
        }

        /// <summary>
        /// Loads change products form
        /// </summary>
        /// <param name="change"> change or add new</param>
        public void LoadProductChange(bool change)
        {
            Product prod = GetSelectedProduct();
            if (prod != null && change)
            {
                view.LoadChangeProduct(new Point(view.Width - 370, 420));
                view.ChangedProduct = prod.Clone();
            }
            else if (!change)
            {
                view.LoadChangeProduct(new Point(view.Width - 370, 420));
            }
            //else
            //{
            //    MessageBox.Show("Nothing to change", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        /// <summary>
        /// Destroyes change products window
        /// </summary>
        public void DestroyProductChange()
        {
            view.DestroyChangeProduct();
        }

        /// <summary>
        /// Add new product to database and product list
        /// </summary>
        /// <param name="prod"> product to add</param>
        public void AddNewProduct(Product prod)
        {
            repos.AddProduct(prod);
            RefreshProductList();
        }

        /// <summary>
        /// Change existing product to new
        /// </summary>
        /// <param name="from"> old product </param>
        /// <param name="to"> new product</param>
        public void ChangeProduct(Product from, Product to)
        {
            repos.DeleteProduct(from);
            repos.AddProduct(to);
            RefreshProductList();
        }

        /// <summary>
        /// loads all users to listView in admin's form
        /// </summary>
        public void LoadUsers()
        {
            List<User> allUsers = repos.GetAllUsers();
            List<User> users = new List<User>();
            foreach (User x in allUsers)
            {
                if (x.Status != "UnloggedUser")
                {
                    users.Add(x);
                }

                view.LoadUsersList(users);
            }
        }

        /// <summary>
        /// loads registration requests
        /// </summary>
        public void LoadRequests()
        {
            List<User> allUsers = repos.GetAllUsers();
            List<User> users = new List<User>();
            foreach (User x in allUsers)
            {
                if (x.Status == "UnloggedUser")
                {
                    users.Add(x);
                }

                view.LoadReqsList(users);
            }
        }

        /// <summary>
        /// admin changes user status
        /// </summary>
        /// <param name="stat">new status</param>
        /// <param name="changedUserName">username of changed user</param>
        public void ChangeUserStatus(string stat, string changedUserName)
        {
            User changed = repos.GetUser(changedUserName);
            repos.DeleteUser(changed);
            changed.Status = stat;
            repos.AddUser(changed);
        }

        /// <summary>
        /// accept user
        /// </summary>
        /// <param name="name">user name</param>
        public void AcceptUser(string name)
        {
            MessageBox.Show(name);
            ChangeUserStatus("LoggedUser", name);
        }

        /// <summary>
        /// reject user
        /// </summary>
        /// <param name="name">user name</param>
        public void RejectUser(string name)
        {
            DeleteUser(name);
        }

        /// <summary>
        /// delete user
        /// </summary>
        /// <param name="name">user name</param>
        public void DeleteUser(string name)
        {
            User userToDel = repos.GetUser(name);
            repos.DeleteUser(userToDel);
        }

        /// <summary>
        /// Validate card number
        /// </summary>
        /// <param name="getPart1">code part1</param>
        /// <param name="getPart2">code part2</param>
        /// <param name="getPart3">code part3</param>
        /// <param name="getPart4">code part4</param>
        /// <returns>true or false</returns>
        public bool ValidateCardNumber(string getPart1, string getPart2, string getPart3, string getPart4)
        {
            ushort n;
            bool res = false;
            if ((getPart1.Length != 4) || (getPart2.Length != 4) || (getPart3.Length != 4) || (getPart4.Length != 4))
            {
                res = false;
            }
            else if (getPart1[0] != '4' && getPart1[0] != '5' && getPart1[0] != '6')
            {
                res = false;
            }
            else if (ushort.TryParse(getPart1, out n) && ushort.TryParse(getPart2, out n) && ushort.TryParse(getPart3, out n) && ushort.TryParse(getPart4, out n))
            {
                res = true;
            }

            return res;
        }

        /// <summary>
        /// Validate CNV Code
        /// </summary>
        /// <param name="getCvn">CNV Code</param>
        /// <returns>true or false</returns>
        public bool ValidateCNVCode(string getCvn)
        {
            ushort n;
            bool res = false;
            if (getCvn.Length != 3)
            {
                res = false;
            }
            else if (ushort.TryParse(getCvn, out n))
            {
                res = true;
            }

            return res;
        }

        /// <summary>
        /// validate date
        /// </summary>
        /// <param name="getMonth">Month</param>
        /// <param name="getYear">Year</param>
        /// <returns>or is norm date</returns>
        public bool ValidateExpDate(string getMonth, string getYear)
        {
            return (getMonth.Length != 0) && (getYear.Length != 0);
        }

        /// <summary>
        /// метод записує в файл інформацію про останню покупку
        /// записує : номер картки , CVN код, дату придатності картки і суму покупки
        /// </summary>
        public void PayAndWrite(string getPart1, string getPart2, string getPart3, string getPart4, string getCvn, string getMonth, string getYear)
        {
           
            if (ValidateCardNumber(getPart1, getPart2, getPart3, getPart4) && ValidateCNVCode(getCvn) && ValidateExpDate(getMonth, getYear))
            {
                DateTime time = DateTime.Now;
                Order ord = new Order();
                ord.Date =  time.Date;
                string tnumber = getPart1 + getPart2 + getPart3 + getPart4;
                ord.CardNumber = tnumber;
                ord.CVN = getCvn;
                ord.UserID = user.ID;
                //ord.ProductID = 
                ord.ExpDate = getMonth + "" + getYear;
                ord.ID++;
                repos.AddOrder(ord);
            //    removeAllFromBasked();
            }
            else
            {
                view.ShowMessage("Wrong input!");
            }
        }
    }
}
