using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineComputerStore.Models
{
    public static class SessionHelper
    {
        private const string Username = "Username";
        private const string Role = "Role";
        private const string DefaultRole = "Customer";
        private const string Adminstrator = "Admin";

        /// <summary>
        /// Return the username of the currently logged in user
        /// or null
        /// </summary>
        /// <returns>returns current logged in user</returns>
        public static string GetUserName()
        {
            if (IsUserLoggedIn())
            {
                return HttpContext.Current
                    .Session[Username]
                    .ToString();
            }
            return null;
        }

        /// <summary>
        /// Checks to see if the user that logged in
        /// is a Customer
        /// </summary>
        /// <returns>returns role is a Customer</returns>
        public static bool IsCustomer()
        {
            if (HttpContext.Current.Session[Role].ToString()
                == DefaultRole)
            {
                return true;
            }
            return false;
        }

        public static void LogUserIn(string username)
        {
            LoggedUserIn(username, DefaultRole);
        }

        public static void LogUserOut()
        {
            HttpContext.Current.Session.Abandon();
        }

        private static void LoggedUserIn(string username, string role)
        {
            HttpContext.Current.Session[Username] = username;

            HttpContext.Current.Session[Role] = role;
        }


        public static bool IsUserLoggedIn()
        {
            if (HttpContext.Current.Session[Username] == null)
                return false;
            return true;
        }

        public static bool IsAdmin()
        {
            string role = HttpContext.Current
                .Session[Role].ToString();
            if (role == Adminstrator)
                return true;
            return false;
        }
    }
}