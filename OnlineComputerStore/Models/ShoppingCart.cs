using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineComputerStore.Models
{
    /*If all the methods in this class are static and you don't have a reason
     * to create any instances of this class, you should mark it as static */
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

        //instead of using "cart" in multiple places you could add a constant
        const string CartCookie = "cart";
        private static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            //instead of using "cart" in multiple places you could add a constant
            //we can avoid magic strings just like magic numbers
            HttpCookie cookieCart = HttpContext.Current.Request.Cookies[CartCookie];
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