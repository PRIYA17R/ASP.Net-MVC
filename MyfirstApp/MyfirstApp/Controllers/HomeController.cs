using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyfirstApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }





        public ActionResult Product()
        {

            return View("OurCompanyProduct");
        }

        public ActionResult Contact()
        {

            return View();
        }
        public ActionResult GetEmployeeData(int id)
        {
            return Content("Employee Details are " + id);
        }

        public ActionResult GetPaySlip(int id )
        {

            var fileName = "PaySlip" + id + ".pdf";
            return File(fileName, "application/pdf");
        }

        public ActionResult StudentDetails()
        {
            ViewBag.StudentId = 10;
            ViewBag.Name = "Geeta";
            ViewBag.Address = "xy, street number 12,Akola 944002";
            ViewBag.Marks = 80;
            ViewBag.Subjects = new List<string> (){ "Physics", "Math", "Chemistry" };
            return View();
        }


        public ActionResult AmountDemon(int? id)
        {
            ViewBag.amount = id;
            return View();
        }


        public ActionResult RequestExample()
        {
            ViewBag.Url = Request.Url;
            ViewBag.PhysicalApplication = Request.PhysicalApplicationPath;
            ViewBag.PhysicalPath = Request.PhysicalPath;
            ViewBag.Headers = Request.Headers["Accept"];
            ViewBag.QueryString = Request.QueryString["n"];
            ViewBag.Browser = Request.Browser;
            ViewBag.HttpMethod =  Request.HttpMethod;
            return View();
        }
    }
}