using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelExample.Models;

namespace ModelExample.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ ProductId = 10, ProductName = "Mobiles" , Rate =40000 },
                new Product(){ ProductId = 11, ProductName = "Bike" , Rate =76000 },
                new Product(){ ProductId = 12, ProductName = "Headphone" , Rate =9000 },
                new Product() { ProductId = 13, ProductName = "Speakers" , Rate =10000 }
            };
            ViewBag.products = products;

            return View();
        }

        public ActionResult Details(int? id)
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ ProductId = 10, ProductName = "Mobiles" , Rate =40000 },
                new Product(){ ProductId = 11, ProductName = "Bike" , Rate =76000 },
                new Product(){ ProductId = 12, ProductName = "Headphone" , Rate =9000 },
                new Product(){ ProductId = 13, ProductName = "Speakers" , Rate =10000 }
            };
            Product matchingProduct = new Product(); 
            
            foreach(var item in products)
            {
                if(item.ProductId == id)
                {
                    matchingProduct = item;
                }
            }
            ViewBag.ProductDetails = matchingProduct;

            return View(matchingProduct);
         
        }
    }
}