using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
            ViewBag.searchText = Search;

             return View(products);
        }

        public ActionResult Details(int? id)
        {
            
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            Product product = db.Products.Where(s => s.ProductID == id).FirstOrDefault();
           return View(product);
        }
       
        public ActionResult Create()
        {

            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
             ViewBag.Brands = db.Brands.ToList();
             ViewBag.Categories = db.Categories.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product prod)
        {
            Product p = new Product() {
            ProductID= prod.ProductID,
            ProductName = prod.ProductName,
            Price = prod.Price,
            DateOfPurchase =prod.DateOfPurchase,
            Active = prod.Active,
            BrandID= prod.BrandID,
            CategoryID = prod.CategoryID
            };

            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();

            db.Products.Add(p);
            db.SaveChanges();

            // List<Product> products = db.Products.ToList();
            return Redirect("/Products/Index");
           
        }

        public ActionResult UpdateProduct(int? id)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            Product prodToUpdate = db.Products.Where(s => s.ProductID == id).FirstOrDefault();
            ViewBag.Brands = db.Brands.ToList();
            ViewBag.Categories = db.Categories.ToList();
            return View(prodToUpdate);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            Product exstingProduct = db.Products.Where(s => s.ProductID == product.ProductID).FirstOrDefault();
            exstingProduct.ProductName = product.ProductName;
            exstingProduct.Price = product.Price;
            exstingProduct.DateOfPurchase = product.DateOfPurchase;
            exstingProduct.AvailabilityStatus = product.AvailabilityStatus;
            exstingProduct.Active = product.Active;
            exstingProduct.BrandID = product.BrandID;
            exstingProduct.CategoryID = product.CategoryID;


            db.SaveChanges();


            return Redirect("/Products/Index");
        }

public ActionResult Delete(int id)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            Product p = db.Products.Where(s => s.ProductID == id).FirstOrDefault();
            return View(p);
        }

        [HttpPost]
        public ActionResult Delete(int id, Product p)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            Product existingRecord = db.Products.Where(s => s.ProductID == id).FirstOrDefault();
            db.Products.Remove(existingRecord);
            db.SaveChanges();
            return RedirectToAction("Index", "Products");
        }
        

    }
}