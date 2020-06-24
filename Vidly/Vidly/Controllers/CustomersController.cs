using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        //GET: Customers
        public ActionResult Index()
        {
            var Customers = GetCustomers();
            return View(Customers);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int? id)
        {
            List<Customer> Customers = GetCustomers().SingleOrDefault(s = s.Id == id);
            if(Customers == null)
            {
                return HttpNotFound();
            }
            
            return View(Customers);
            
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> Customers = new List<Customer>{
                new Customer { Id =1, Name = " Priya Rewaskar"},
                new Customer { Id = 2, Name = "Shashank Wankhede" }
            };

            return Customers;
        }
    }
}