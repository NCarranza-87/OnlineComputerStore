using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineComputerStore.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        [Phone]
        public string MobilePhone { get; set; }

        [Required]
        public string FullName { get; set; }


        public string Address { get; set; }
    }
}