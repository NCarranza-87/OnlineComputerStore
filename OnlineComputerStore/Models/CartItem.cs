﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace OnlineComputerStore.Models
{
    public class CartItem
    {
        [Key]
        public string ItemID { get; set; }

        public string CartID { get; set; }

        public int Quantity { get; set; }

        public int ProductID { get; set; }

    }
}