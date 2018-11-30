using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineComputerStore.Models
{
    public class ProductDB
    {
        public static List<Product> GetAllProducts()
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            List<Product> products = (from p in dbContext.Products
                                      orderby p.ProductName
                                      select p).ToList();
            return products;
        }

        public static int GetTotalProducts()
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            return dbContext.Products.Count();
        }

        public static List<Product> GetTotalProductsByPage(int page, byte pageSize)
        {
            ApplicationDbContext con = new ApplicationDbContext();

            List<Product> prodList = con.Products
                                        .Take(pageSize)
                                        .OrderBy(p => p.ProductName)
                                        .Skip((page - 1) * pageSize).ToList();
            return prodList;
        }

        public static List<Product> GetProductsByPage(int page, byte pageSize)
        {
            ApplicationDbContext con = new ApplicationDbContext();

            List<Product> prodList = con.Products.Take(pageSize)
                                                 .OrderBy(p => p.ProductName)
                                                 .Skip((page - 1) * pageSize)
                                                 .ToList();
            return prodList;
        }

        public static void AddProduct(Product prod)
        {
            ApplicationDbContext con = new ApplicationDbContext();

            con.Products.Add(prod);

            con.SaveChanges();
        }

        public static Product GetProductById(int id)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();

            Product p = dbContext.Products.Find(id);
            return p;
        }

        public static void Update(Product product)
        {
            ApplicationDbContext con = new ApplicationDbContext();

            con.Entry(product).State = EntityState.Modified;

            con.SaveChanges();
        }

        public static void DeleteProduct(int id)
        {
            ApplicationDbContext con = new ApplicationDbContext();

            Product prod = con.Products.Find(id);

            con.Products.Remove(prod);

            con.SaveChanges();
        }
    }
}