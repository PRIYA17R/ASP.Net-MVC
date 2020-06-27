using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDbFirstApproach.Models;

namespace EFDbFirstApproach.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index(string Search = "")
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
           
            List<Product> products = db.Products.Where(t => t.ProductName.Contains(Search)).ToList();

            //    SqlParameter[] sqlParameters = new SqlParameter[]
            //    {
            //        new SqlParameter("@BrandID", 2)
            //    };

            //List<Product> products = db.Database.SqlQuery<Product>("exec GetProductIdByBrand @BrandID ", sqlParameters).ToList();

            ViewBag.searchText = Search;

         return View(products);
        }
    }
}