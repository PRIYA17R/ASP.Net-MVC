using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutExample.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        [Route ("Products/GetProducts/{productId:int?}")]
        public ActionResult GetProducts(int? productId)
        {
            var products = new[] {
             new   { productId = 10, ProductName= "Mobile"},
              new   { productId = 11, ProductName= "Mobile"},
               new   { productId = 12, ProductName= "Mobile"}
            };
            string message = string.Empty;
            foreach (var product in products)
            {
                if (productId == product.productId)
                {
                    message = product.ProductName;
                    break;
                }
                else
                {
                    message = "Product is not matching";
                }
            }
            return Content(message);



        }
    }
}