//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public int ID { get; set; }

        public User()
        {
            UserName = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            Phone = string.Empty;
            Adress = string.Empty;
            Country = string.Empty;
            ZipCode = string.Empty;
            Gender = string.Empty;
            Status = string.Empty;
        }
        public User(string userName, string firstName, string lastName, string email, string password, string phone, string adress, string country, string zipCode, string gender, string status)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Phone = phone;
            Adress = adress;
            Country = country;
            ZipCode = zipCode;
            Gender = gender;
            Status = status;
        }

        public User Clone()
        {
            User res = new User();
            res.UserName = (string)UserName.Clone();
            res.FirstName = (string)FirstName.Clone();
            res.LastName = (string)LastName.Clone();
            res.Email = (string)Email.Clone();
            res.Password = (string)Password.Clone();
            res.Phone = (string)Phone.Clone();
            res.Adress = (string)Adress.Clone();
            res.Country = (string)Country.Clone();
            res.ZipCode = (string)ZipCode.Clone();
            res.Gender = (string)Gender.Clone();
            res.Status = (string)Status.Clone();
            res.ID = ID;
            return res;
        }
    }
}
