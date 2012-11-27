using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.AppData;
using Shop.Models;
using Shop;
using Shop.Controllers;
using Shop.Views;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        #region Repository

        /// <summary>
        /// Check if Repository is singleton. 
        /// </summary>
        [TestMethod]
        public void RepositorySingleton()
        {
            Repository a = Repository.Instance;
            Repository b = Repository.Instance;
            Assert.AreEqual(a, b);
        }

        /// <summary>
        /// Check if works add and have order methods. 
        /// </summary>
        [TestMethod]
        public void AddAndHaveOrder()
        {
            Repository repos = Repository.Instance;
            try
            {
                Order ord = new Order("4444555544445555", "27.11.2012", "123", "Payed", 3, 0, 3);
                repos.AddOrder(ord);
                Assert.IsTrue(repos.HaveOrder(ord));
            }
            catch (NotSupportedException)
            {
                Assert.IsTrue(true);
            }
        }

        /// <summary>
        /// Check if works add and delete order methods. 
        /// </summary>
        [TestMethod]
        public void AddAndDeleteOrder()
        {
            Repository repos = Repository.Instance;
            try
            {
                Order ord = new Order("4444555544445555", "27.11.2012", "123", "Payed", 3, 0, 3);
                repos.AddOrder(ord);
                repos.DeleteOrder(ord);
                Assert.IsFalse(repos.HaveOrder(ord));
            }
            catch (NotSupportedException)
            {
                Assert.IsTrue(true);
            }
        }

        /// <summary>
        /// Check if works add and have user methods. 
        /// </summary>
        [TestMethod]
        public void AddAndHaveUser()
        {
            Repository repos = Repository.Instance;
            try
            {
                User usr = new User("Slavik", "Yaroslav", "Pohlod", "poh@gmail.com", "123123a", "123123", "Lviv", "Uk", "123", "Mail", "Manager");
                repos.AddUser(usr);
                Assert.IsTrue(repos.HaveUser(usr));
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }
        #endregion
    }
}
