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
    }
}
