// -----------------------------------------------------------------------
// <copyright file="Validator.cs" company="fjhjf">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// password validation
        /// </summary>
        /// <param name="pass">password</param>
        /// <returns>bool</returns>      
        public static bool ValidatePassword(string pass)
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
        public static bool ValidateConfirmedPassword(string pass1, string pass2)
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
        /// emails validating
        /// </summary>
        /// <param name="email">email text</param>
        /// <returns>bool</returns>
        public static bool ValidateEmail(string email)
        {
            bool val = email.Contains('@') && email.Contains('.')
                && (email.Length - email.LastIndexOf('.') == 3
                || email.Length - email.LastIndexOf('.') == 4);
            return val;
        }

        /// <summary>
        /// Validate card number
        /// </summary>
        /// <param name="getPart1">code part1</param>
        /// <param name="getPart2">code part2</param>
        /// <param name="getPart3">code part3</param>
        /// <param name="getPart4">code part4</param>
        /// <returns>true or false</returns>
        public static bool ValidateCardNumber(string getPart1, string getPart2, string getPart3, string getPart4)
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
        /// validate date
        /// </summary>
        /// <param name="getMonth">Month</param>
        /// <param name="getYear">Year</param>
        /// <returns>or is norm date</returns>
        public static bool ValidateExpDate(string getMonth, string getYear)
        {
            return (getMonth.Length != 0) && (getYear.Length != 0);
        }

        /// <summary>
        /// Validate CNV Code
        /// </summary>
        /// <param name="getCvn">CNV Code</param>
        /// <returns>true or false</returns>
        public static bool ValidateCNVCode(string getCvn)
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


    }
}
