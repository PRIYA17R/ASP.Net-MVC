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
        public ActionResult Index()
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            // List<Product> products = db.Products.ToList();
            //  List<Product> products = db.Products.Where(t => t.CategoryID == 1).ToList();

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@BrandID", 2)
            };

        List<Product> products = db.Database.SqlQuery<Product>("exec GetProductIdByBrand @BrandID ", sqlParameters).ToList();
            return View(products);
        }
    }
}