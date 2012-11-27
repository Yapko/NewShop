using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Collections.Generic;
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
            //try
            //{
            repos.DeleteAllOrders();
                Order ord = new Order("4444555544445555", "27.11.2012", "123", "Payed", 3, 0, 3);
                repos.AddOrder(ord);
                Assert.IsTrue(repos.HaveOrder(ord));
            //}
            //catch (NotSupportedException)
            //{
            //    Assert.IsTrue(true);
            //}
        }

        /// <summary>
        /// Check if works add and delete order methods. 
        /// </summary>
        [TestMethod]
        public void AddAndDeleteOrder()
        {
            Repository repos = Repository.Instance;
           // try
           // {
            repos.DeleteAllOrders();
                Order ord = new Order("4444555544445555", "27.11.2012", "123", "Payed", 3, 0, 3);
                repos.AddOrder(ord);
                repos.DeleteOrder(ord);
                Assert.IsFalse(repos.HaveOrder(ord));
          //  }
          //  catch (NotSupportedException)
          //  {
          //      Assert.IsTrue(true);
          //  }
        }

        /// <summary>
        /// Check if works add and have user methods. 
        /// </summary>
        [TestMethod]
        public void AddAndHaveUser()
        {
            Repository repos = Repository.Instance;
            //try
            //{
            repos.DeleteAllUsers();
                User usr = new User("Slavik", "Yaroslav", "Pohlod", "poh@gmail.com", "123123a", "123123", "Lviv", "Uk", "123", "Mail", "Manager");
                repos.AddUser(usr);
                Assert.IsTrue(repos.HaveUser(usr));
            //}
            //catch (Exception)
            //{
            //    Assert.IsTrue(true);
            //}
        }

        /// <summary>
        /// Check if works add and delete user methods. 
        /// </summary>
        [TestMethod]
        public void AddAndDeleteUser()
        {
            Repository repos = Repository.Instance;
            // try
            // {
            repos.DeleteAllUsers();
            User usr = new User("Slavik", "Yaroslav", "Pohlod", "poh@gmail.com", "123123a", "123123", "Lviv", "Uk", "123", "Mail", "Manager");
            repos.AddUser(usr);
            repos.DeleteUser(usr);
            Assert.IsFalse(repos.HaveUser(usr.UserName));
            //  }
            //  catch (NotSupportedException)
            //  {
            //      Assert.IsTrue(true);
            //  }
        }

        /// <summary>
        /// Check if works add and get user methods. 
        /// </summary>
        [TestMethod]
        public void AddAndGetUser()
        {
            Repository repos = Repository.Instance;
            // try
            // {
            repos.DeleteAllUsers();
            User usr = new User("Slavik", "Yaroslav", "Pohlod", "poh@gmail.com", "123123a", "123123", "Lviv", "Uk", "123", "Mail", "Manager");
            repos.AddUser(usr);
            Assert.AreEqual(repos.GetUser(usr.UserName),usr);
            //  }
            //  catch (NotSupportedException)
            //  {
            //      Assert.IsTrue(true);
            //  }
        }

        /// <summary>
        /// Check if works add and have product methods. 
        /// </summary>
        [TestMethod]
        public void AddAndHaveProduct()
        {
            Repository repos = Repository.Instance;
            //try
            //{
            repos.DeleteAllProducts();
            Product prd = new Product(new byte[5], "prod", "nice", "home", 0);
            repos.AddProduct(prd);
            Assert.IsTrue(repos.HaveProduct(prd));
            //}
            //catch (NotSupportedException)
            //{
            //    Assert.IsTrue(true);
            //}
        }

        /// <summary>
        /// Check if works add and delete product methods. 
        /// </summary>
        [TestMethod]
        public void AddAndDeleteProduct()
        {
            Repository repos = Repository.Instance;
            // try
            // {
            repos.DeleteAllProducts();
            Product prd = new Product(new byte[5], "prod", "nice", "home", 0);
            repos.AddProduct(prd);
            repos.DeleteProduct(prd);
            Assert.IsFalse(repos.HaveProduct(prd.Name));
            //  }
            //  catch (NotSupportedException)
            //  {
            //      Assert.IsTrue(true);
            //  }
        }

        #endregion

        #region validations
        
        /// <summary>
        /// Test password validation
        /// </summary>
        [TestMethod]
        public void ValidatePasswordTest()
        {
            Assert.IsTrue(Validator.ValidatePassword("123123123a") && !Validator.ValidatePassword("123"));
        }

        /// <summary>
        /// Test CNV Code validation
        /// </summary>
        [TestMethod]
        public void ValidateCNVCodeTest()
        {
            Assert.IsTrue(Validator.ValidateCNVCode("123") && !Validator.ValidateCNVCode("12a"));
        }

        /// <summary>
        /// Test CNV Code validation
        /// </summary>
        [TestMethod]
        public void ValidateCardNumberTest()
        {
            Assert.IsTrue(Validator.ValidateCardNumber("4532", "4532", "4532", "4532") && !Validator.ValidateCardNumber("1532", "4532", "4532", "453"));
        }

        /// <summary>
        /// Test Confirmed Password validation
        /// </summary>
        [TestMethod]
        public void ValidateConfirmedPasswordTest1()
        {
            Assert.IsTrue(Validator.ValidateConfirmedPassword("4532", "4532"));
        }

        /// <summary>
        /// Test Confirmed Password validation
        /// </summary>
        [TestMethod]
        public void ValidateConfirmedPasswordTest2()
        {
            Assert.IsFalse(Validator.ValidateConfirmedPassword("1532", "453"));
        }

        /// <summary>
        /// Test Confirmed Password validation
        /// </summary>
        [TestMethod]
        public void ValidateConfirmedPasswordTest3()
        {
            Assert.IsFalse(Validator.ValidateConfirmedPassword("1532", "4531"));
        }

        /// <summary>
        /// Test Email validation
        /// </summary>
        [TestMethod]
        public void ValidateEmailTest()
        {
            Assert.IsTrue(Validator.ValidateEmail("pohlod.slavik@gmail.com") && !Validator.ValidateEmail("1532@.a"));
        }

        /// <summary>
        /// Test Expires Date validation
        /// </summary>
        [TestMethod]
        public void ValidateExpDateTest()
        {
            Assert.IsTrue(Validator.ValidateExpDate("12", "2013") && !Validator.ValidateExpDate("asd","2010"));
        }
        #endregion
        #region AppData

        /// <summary>
        /// Check if works products image get/set methods. 
        /// </summary>
        [TestMethod]
        public void GetAndSetImageProduct()
        {
            Product prd = new Product();
            Image img = new Bitmap(100,100);
            prd.SetImage(img);
            Image img2 = img = prd.GetImage();
            Assert.AreEqual(img,img2);
        }

        /// <summary>
        /// Test Order constructor 
        /// </summary>
        [TestMethod]
        public void OrderConstructorTest()
        {
            Order a = new Order();
            Order b = new Order();
            Assert.AreNotEqual(a,b);
        }

        /// <summary>
        /// Test class Line
        /// </summary>
        [TestMethod]
        public void LineTest()
        {
            Line l1 = new Line();
            l1.Cl = Color.Red;
            l1.X = new Point(1, 2);
            l1.Y = new Point(5, 6);
            Assert.IsNotNull(l1);
        }

        #endregion
    }
}
