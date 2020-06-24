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
    }
}