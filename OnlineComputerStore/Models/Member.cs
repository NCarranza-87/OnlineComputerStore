using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineComputerStore.Models
{
    public class Member
    {
        public int MemberId { get; set; }

        public string Username { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public string MobilePhone { get; set; }

        public string FullName { get; set; }

        public string CreditCard { get; set; }

        public string Address { get; set; }
    }
}