﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;


namespace ModelExample.Models
{
    public class CustomBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            int StudentId = Convert.ToInt32(controllerContext.HttpContext.Request.Form["StudentId"]);
            string StudentName = controllerContext.HttpContext.Request.Form["StudentName"];
            string StudentDno = controllerContext.HttpContext.Request.Form["Dno"];
            string Street = controllerContext.HttpContext.Request.Form["Street"];
            string Landmark = controllerContext.HttpContext.Request.Form["Landmark"];
            string City = controllerContext.HttpContext.Request.Form["City"];
            return new Student() { StudentId = StudentId, StudentName = StudentName, Address = StudentDno + " , " + Street + " , " + Landmark + " , " + City };

        }

    }
}