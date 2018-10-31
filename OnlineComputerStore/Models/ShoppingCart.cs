using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineComputerStore.Models
{
    public class ShoppingCart
    {
        public static short GetTotalItems()
        {
            List<Product> products = GetProducts();
            short numProducts = 0;
            
            foreach (Product p in products)
            {
                numProducts += p.ProductQty;
            }
            return numProducts;
        }

        private static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            HttpCookie cookieCart = HttpContext.Current.Request.Cookies["cart"];
            if (cookieCart == null)
                return products;

            products = JsonConvert.DeserializeObject<List<Product>>(cookieCart.Value);
            return products;
        }

        public static void AddProduct(Product p)
        {
            List<Product> products = new List<Product>();
            HttpCookie cart = HttpContext.Current.Request.Cookies["cart"];
            products = JsonConvert.DeserializeObject<List<Product>>(cart.Value);
            products.Add(p);

            string jsonData = JsonConvert.SerializeObject(products);

            HttpCookie cookie = new HttpCookie("cart");
            cookie.Value = jsonData;
            cookie.Expires = DateTime.Now.AddDays(6);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

    }
}