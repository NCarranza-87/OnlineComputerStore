using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineComputerStore.Models
{
    public class ProductSearchModel
    {
        public ProductSearchModel()
        {
            SearchProductResults = new List<Product>();
        }

        public string ProductName { get; set; }

        public double? MinPrice { get; set; }

        public double? MaxPrice { get; set; }

        public string ProductCategory { get; set; }

        public List<Product> SearchProductResults { get; set; }
    }
}