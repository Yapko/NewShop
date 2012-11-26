namespace Shop.Views
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Windows.Forms.Integration;
    using Shop.Controllers;
    using Shop.AppData;
    
    /// <summary>
    /// Main form
    /// </summary>
    public partial class MainWnd : Form
    {
        /// <summary>
        /// Controll class of this view
        /// </summary>
        private MainController control;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWnd"/> class.
        /// </summary>
        /// <param name="newControl">class witch controls this form</param>
        public MainWnd(MainController newControl)
        {
            InitializeComponent();
            control = newControl;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
        }

        /// <summary>
        /// Shows message to user via messagebox
        /// </summary>
        /// <param name="message">message wich want to show</param>
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        /// <summary>
        /// method of closing picture
        /// </summary>
        /// <param name="sender">app sender</param>
        /// <param name="e">app param</param>
        private void ClosePricure_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Method which load all data to form
        /// </summary>
        /// <param name="sender">app sender</param>
        /// <param name="e">app param</param>
        private void Form1_Load(object sender, EventArgs e)
        {            
            // to create close icon
            LoadCloseIcon();            
        }

        /// <summary>
        /// Create close icon in main form
        /// </summary>
        private void LoadCloseIcon()
        {
            // create picturebox for icon
            PictureBox closePictureBox = new PictureBox();
            // set location in right upper corner
            closePictureBox.Location = new Point(this.Width - 30, 10);
            // set icon
            closePictureBox.Image = Properties.Resources.GreyCloseIcon;
            // set event 
            closePictureBox.Click += ClosePricure_Click;

            // creating tooltip for close icon
            ToolTip closePictureBoxToolTip = new ToolTip();
            closePictureBoxToolTip.ShowAlways = true;           
            closePictureBoxToolTip.SetToolTip(closePictureBox, "Close");  
          
            // add complete picture box to mainform controls
            this.Controls.Add(closePictureBox);
        }

        /// <summary>
        /// Create login in main form
        /// </summary>
        /// <param name="position">position of upper left ungle </param>
        public void LoadLogin(Point position)
        {
            //create login
            LoginControl login = new LoginControl(control);
            // set location in center of form
            login.Location = position;

            // add login to mainform controls
            this.Controls.Add(login);
        }

        /// <summary>
        /// Create card payment in main form
        /// </summary>
        /// <param name="position">position of upper left ungle </param>
        public void LoadPayment(Point position)
        {
            HostForCardPayment cp = new HostForCardPayment(control);
            cp.Location = position;
            this.Controls.Add(cp);
        }

        /// <summary>
        /// Destroys Login control
        /// </summary>
        public void PaymentDestroy()
        {
            RemoveFromControls("HostForCardPayment");
        }

        /// <summary>
        /// Destroys Login control
        /// </summary>
        public void LoginDestroy()
        {
            RemoveFromControls("LoginControl");
        }

        /// <summary>
        /// Create Manager form in main form
        /// </summary>
        /// <param name="position">position of upper left ungle </param>
        public void LoadManager(Point position)
        {
            //create login
            ManagerControl mng = new ManagerControl(control);
            // set location in center of form
            mng.Location = position;

            // add login to mainform controls
            this.Controls.Add(mng);
        }

        /// <summary>
        /// Destroys Login control
        /// </summary>
        public void ManagerDestroy()
        {
            RemoveFromControls("ManagerControl");
        }

        /// <summary>
        /// Load user view
        /// </summary>
        /// <param name="position"> screen position </param>
        /// <param name="username"> user username </param>
        /// <param name="role"> user status </param>
        public void LoadUserView(Point position, string username, string role)
        {
            //create login
            UserControlView uc = new UserControlView(control, username, role);
            // set location in center of form
            uc.Location = position;

            // add login to mainform controls
            this.Controls.Add(uc);
        }

        /// <summary>
        /// Destroyes User view
        /// </summary>
        public void DestroyUserView()
        {
            RemoveFromControls("UserControlView");
        }
        
        /// <summary>
        /// Load login form
        /// </summary>
        /// <param name="sender"> message sender </param>
        /// <param name="e"> event </param>
        private void Login_Click(object sender, EventArgs e)
        {
            LoadLogin(new Point(2, 30));
        }

        /// <summary>
        /// Set value to enable basket button
        /// </summary>
        /// <param name="value"> eneble of disable </param>
        public void SetUserViewBasketButton(bool value)
        {
            if (Controls.ContainsKey("UserControlView") == true)
            {
                ((UserControlView)Controls[Controls.IndexOfKey("UserControlView")]).BasketButton = value;
            }
        }

        /// <summary>
        /// Set value to enable product button
        /// </summary>
        /// <param name="value"> eneble of disable </param>
        public void SetUserViewProductsButton(bool value)
        {
            if (Controls.ContainsKey("UserControlView") == true)
            {
                ((UserControlView)Controls[Controls.IndexOfKey("UserControlView")]).ProductsButton = value;
            }
        }

        /// <summary>
        /// Create account in main form
        /// </summary>
        /// <param name="position">position of upper left ungle</param>
        /// <param name="curr">this user</param>
        public void LoadAccount(Point position, User curr)
        {
            //create login
            PersonalAccountControl account = new PersonalAccountControl(control, curr);
            // set location in center of form
            account.Location = position;

            // add login to mainform controls
            this.Controls.Add(account);
        }

        /// <summary>
        /// destroy personal account
        /// </summary>
        public void DestroyAccount()
        {
            //this.Controls[controlsPos["Personal account"]].Dispose();
            RemoveFromControls("PersonalAccountControl");
        }

        /// <summary>
        /// Create change product control in main form
        /// </summary>
        /// <param name="position">position of upper left ungle</param>
        public void LoadChangeProduct(Point position)
        {
            ProductChangeControl prod = new ProductChangeControl(control);
            prod.Location = position;
            this.Controls.Add(prod);
        }

        /// <summary>
        /// destroy product change control
        /// </summary>
        public void DestroyChangeProduct()
        {
            RemoveFromControls("ProductChangeControl");
        }

        /// <summary>
        /// Gets or sets changed product
        /// </summary>
        public Product ChangedProduct
        {
            get
            {
                if (Controls.ContainsKey("ProductChangeControl") == true)
                {
                    return ((ProductChangeControl)Controls[Controls.IndexOfKey("ProductChangeControl")]).ChangedProduct;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (Controls.ContainsKey("ProductChangeControl") == true)
                {
                    ((ProductChangeControl)Controls[Controls.IndexOfKey("ProductChangeControl")]).ChangedProduct = value;
                }
            }
        }

        /// <summary>
        /// adds producst list to controls
        /// </summary>
        /// <param name="prods">products to be added to view</param>
        public void LoadProductsList(List<Product> prods)
        {
            ProductsListControl plc = new ProductsListControl(control, prods);
            DestroyProductsList();
            this.Controls.Add(plc);
        }

        /// <summary>
        /// adds user producst list to controls
        /// </summary>
        /// <param name="prods">products to be added to view</param>
        public void LoadUserProductsList(List<Product> prods)
        {
            //ProductsListControl plc = new ProductsListControl(control, prods);
            UserBasked ub = new UserBasked(control, prods);
            this.Controls.Add(ub);
        }

        /// <summary>
        /// destroys ProductsList from screen
        /// </summary>
        public void DestroyProductsList()
        {
            //this.Controls[controlsPos["ProductsList"]].Dispose();
            RemoveFromControls("ProductsListControl");
        }

        /// <summary>
        /// destroys UserProductsList from screen
        /// </summary>
        public void DestroyUserProductsList()
        {
            //this.Controls[controlsPos["ProductsList"]].Dispose();
            RemoveFromControls("UserBasked");
        }

        /// <summary>
        /// loads registration view at position
        /// </summary>
        /// <param name="position">position in parent window were registration window will be shown</param>
        public void LoadRegister(Point position)
        {
            RegistrationView regView = new RegistrationView(control);
            regView.Location = position;
            this.Controls.Add(regView);
            //LoadCaptcha(new Point(165, 321));
        }

        /// <summary>
        /// method to destroy register window from parent window
        /// </summary>
        public void DestroyRegisterView()
        {            
            RemoveFromControls("RegistrationView");
        }

        /// <summary>
        /// Gets selected product
        /// </summary>
        /// <returns> selected product</returns>
        public Product GetSelectedProduct()
        {
            if (Controls.ContainsKey("ProductsListControl") == true)
            {
                return ((ProductsListControl)Controls[Controls.IndexOfKey("ProductsListControl")]).GetFocused();
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// removes control by its name
        /// </summary>
        /// <param name="toRemove">control to be removed</param>
        private void RemoveFromControls(string toRemove)
        {
            if (Controls.ContainsKey(toRemove) == true)
            {
                Controls[Controls.IndexOfKey(toRemove)].Dispose();
            }
            //else
            //{
            //    MessageBox.Show("Element missing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        /// <summary>
        /// Create admin view in main view
        /// </summary>
        /// <param name="position">position of upper left ungle </param>
        public void LoadAdmin(Point position)
        {
            //create login
            AdminView admin = new AdminView(control);
            // set location in center of form
            admin.Location = position;

            // add login to mainform controls
            this.Controls.Add(admin);
        }

        /// <summary>
        /// Destroys admin view
        /// </summary>
        public void AdminDestroy()
        {
            RemoveFromControls("AdminView");
        }

        /// <summary>
        /// loads users to usersListView in admin's view
        /// </summary>
        /// <param name="users">users to load</param>
        public void LoadUsersList(List<User> users)
        {
            ((AdminView)Controls[Controls.IndexOfKey("AdminView")]).UsersList.Items.Clear();
            foreach (User x in users)
            {
                ListViewItem temp = new ListViewItem(x.UserName);
                temp.SubItems.Add(x.Status);
                ((AdminView)Controls[Controls.IndexOfKey("AdminView")]).UsersList.Items.Add(temp);
            }

            ((AdminView)Controls[Controls.IndexOfKey("AdminView")]).Refresh();
        }

        /// <summary>
        /// loads requestss to rquestsListView in admin's view
        /// </summary>
        /// <param name="users">unregistered users to load</param>
        public void LoadReqsList(List<User> users)
        {
            ((AdminView)Controls[Controls.IndexOfKey("AdminView")]).ReqsList.Items.Clear();
            foreach (User x in users)
            {
                ListViewItem temp = new ListViewItem(x.UserName);
                temp.SubItems.Add(x.Email);
                temp.SubItems.Add(x.FirstName);
                temp.SubItems.Add(x.LastName);
                ((AdminView)Controls[Controls.IndexOfKey("AdminView")]).ReqsList.Items.Add(temp);
            }

            ((AdminView)Controls[Controls.IndexOfKey("AdminView")]).Refresh();
        }
    }
}
