using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shop.AppData;

namespace Shop.Models
{
    /// <summary>
    /// Singleton class
    /// </summary>
    public class Repository
    {
        /// <summary>
        /// repository item
        /// </summary>
        private static Repository instance = null;

        /// <summary>
        /// data base
        /// </summary>
        private DatabaseEntities database;

        /// <summary>
        /// Prevents a default instance of the <see cref="Repository"/> class from being created.
        /// </summary>
        private Repository()
        {
            database = new DatabaseEntities();
            database.Configuration.AutoDetectChangesEnabled = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository"/> class.
        /// </summary>
        /// <param name="elem">element to copy</param>
        private Repository(Repository elem)
        {
        }

        /// <summary>
        /// Gets instance of Repository element
        /// </summary>
        public static Repository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Repository();
                }

                return instance;
            }
        }

        // Set get have methods
        #region Orders operations

        /// <summary>
        /// Method adds order to database
        /// </summary>
        /// <param name="element">element no add</param>
        public void AddOrder(Order element)
        {
            database.Orders.Add(element);
            database.SaveChanges();
        }

        /// <summary>
        /// Method delete order from database
        /// </summary>
        /// <param name="element">element to delete</param>
        public void DeleteOrder(Order element)
        {
            database.Orders.Remove(element);
            this.database.SaveChanges();
        }

        /// <summary>
        /// Check if database has such order
        /// </summary>
        /// <param name="element">element to check</param>
        /// <returns>if element exist</returns>
        public bool HaveOrder(Order element)
        {
            return database.Orders.Contains(element);
        }

        /// <summary>
        /// Ads list of orders to database.
        /// </summary>
        /// <param name="elements"> list of orders to add. </param>
        public void AddOrders(List<Order> elements)
        {
            for (int i = 0; i < elements.Count; ++i)
            {
                database.Orders.Add(elements[i]);
            }

            database.SaveChanges();
        }

        /// <summary>
        /// Delete all orders from database.
        /// </summary>
        public void DeleteAllOrders()
        {
            List<Order> lst = new List<Order>();
            lst = database.Orders.ToList();
            for (int i = 0; i < lst.Count; ++i)
            {
                database.Orders.Remove(lst[i]);
            }

            database.SaveChanges();
        }

        /// <summary>
        /// Gets all orders in database.
        /// </summary>
        /// <returns>List of all deposits.</returns>
        public List<Order> GetAllOrders()
        {
            return database.Orders.ToList();
        }
        #endregion

        #region User operations

        /// <summary>
        /// add user to database.
        /// </summary>
        /// <param name="element"> element to add</param>
        public void AddUser(User element)
        {
            database.Users.Add(element);
            database.SaveChanges();
        }

        /// <summary>
        /// add list of users to database.
        /// </summary>
        /// <param name="elements">list of elements to add</param>
        public void AddUsers(List<User> elements)
        {
            for (int i = 0; i < elements.Count; ++i)
            {
                database.Users.Add(elements[i]);
                database.SaveChanges();
            }

            database.SaveChanges();
        }

        /// <summary>
        /// delete all users from database.
        /// </summary>
        public void DeleteAllUsers()
        {
            List<User> lst = new List<User>();
            lst = this.database.Users.ToList();
            for (int i = 0; i < lst.Count; ++i)
            {
                database.Users.Remove(lst[i]);
            }

            database.SaveChanges();
        }

        /// <summary>
        /// delete current user from database.
        /// </summary>
        /// <param name="element">user to delete</param>
        public void DeleteUser(User element)
        {
            database.Users.Remove(element);
            database.SaveChanges();
        }

        /// <summary>
        /// Check if such user exists in database.
        /// </summary>
        /// <param name="element">element to check</param>
        /// <returns>if element exist</returns>
        public bool HaveUser(User element)
        {
            return database.Users.Contains(element);
        }

        /// <summary>
        /// Check if such user exists in database.
        /// </summary>
        /// <param name="username">username of user to check</param>
        /// <returns>if element exist</returns>
        public bool HaveUser(string username)
        {
            return database.Users.Where(u => u.UserName == username).Count() > 0;
        }

        /// <summary>
        /// gets all users
        /// </summary>
        /// <returns>list of users</returns>
        public List<User> GetAllUsers()
        {
            return database.Users.ToList();
        }

        /// <summary>
        /// gets user
        /// </summary>
        /// <param name="username">user name</param>
        /// <returns> found user </returns>
        public User GetUser(string username)
        {
            return this.database.Users.Where(u => u.UserName == username).FirstOrDefault();
        }

        #endregion
        #region Products operations
        /// <summary>
        /// Add product to database.
        /// </summary>
        /// <param name="element">element to add</param>
        public void AddProduct(Product element)
        {
            database.Products.Add(element);
            database.SaveChanges();
        }

        /// <summary>
        /// add list of products to database.
        /// </summary>
        /// <param name="elements">list of elements to add</param>
        public void AddProducts(List<Product> elements)
        {
            for (int i = 0; i < elements.Count; ++i)
            {
                database.Products.Add(elements[i]);
            }

            database.SaveChanges();
        }

        /// <summary>
        /// delete current product from database
        /// </summary>
        /// <param name="element">element to delete</param>
        public void DeleteProduct(Product element)
        {
            database.Products.Remove(element);
            database.SaveChanges();
        }

        /// <summary>
        /// Check if current product exist in database.
        /// </summary>
        /// <param name="element">element to check</param>
        /// <returns>if element exist</returns>
        public bool HaveProduct(Product element)
        {
            return database.Products.Contains(element);
        }

        /// <summary>
        /// Check if product with current name exist in database.
        /// </summary>
        /// <param name="name">name of product</param>
        /// <returns>if element exist</returns>
        public bool HaveProduct(string name)
        {
            return this.database.Products.Where(u => u.Name == name).Count() > 0;
        }

        /// <summary>
        /// gets list of all products in database
        /// </summary>
        /// <returns>list of all products</returns>
        public List<Product> GetAllProducts()
        {
            return database.Products.ToList();
        }

        /// <summary>
        /// delete all products from database.
        /// </summary>
        public void DeleteAllProducts()
        {
            List<Product> lst = new List<Product>();
            lst = database.Products.ToList();
            for (int i = 0; i < lst.Count; ++i)
            {
                this.database.Products.Remove(lst[i]);
            }
        }

        /// <summary>
        /// Get product with current name from database.
        /// </summary>
        /// <param name="name">name of product</param>
        /// <returns>product or default value is such element not exists</returns>
        public Product GetProducts(string name)
        {
            return this.database.Products.Where(u => u.Name == name).FirstOrDefault();
        }

        #endregion

        #region additional functioanlity

        /// <summary>
        /// Gets orders of current users
        /// </summary>
        /// <param name="username">usernme of current user</param>
        /// <returns> his orders </returns>
        public List<Order> GetOrdersOfUser(string username)
        {
            List<Order> res = new List<Order>();
            if (!HaveUser(username))
            {
                return null;
            }

            User user = GetUser(username);
            res = database.Orders.Where(o => o.UserID == user.ID).ToList();
            return res;
        }

        /// <summary>
        /// Gets orders of current users
        /// </summary>
        /// <param name="user">current user</param>
        /// <returns> his orders </returns>
        public List<Order> GetOrdersOfUser(User user)
        {
            List<Order> res = new List<Order>();
            if (!HaveUser(user.UserName))
            {
                return null;
            }

            res = database.Orders.Where(o => o.UserID == user.ID).ToList();
            return res;
        }

        #endregion
    }
}
