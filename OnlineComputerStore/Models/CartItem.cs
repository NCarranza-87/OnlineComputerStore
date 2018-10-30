using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineComputerStore.Models
{
    public class CartItem
    {
        [key]
        public string ItemID { get; set; }

        public string CartID { get; set; }

        public int Quantity { get; set; }

        public int ProductID { get; set; }

        public virtual Product Product { get; set; }


    }
}