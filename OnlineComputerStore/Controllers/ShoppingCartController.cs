using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineComputerStore.Models;

namespace OnlineComputerStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Add(int id)
        {
            // get a product by id
            Product p = ProductDB.GetProductById(id);

            // the user is only adding a single proudct
            // at one time
            p.ProductQty = 1;

            ShoppingCart.AddProduct(p);


            return View(p);
        }

        public ActionResult ViewCart()
        {
            // Allow the user to view the items in the
            // shopping cart
            throw new NotImplementedException();
        }
    }
}