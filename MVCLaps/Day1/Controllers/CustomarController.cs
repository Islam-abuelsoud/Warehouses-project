using Day1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1.Controllers
{
    public class CustomarController : Controller
    {
        public RedirectToRouteResult Add(int id, string name)
        {
            //Customar c1 = new Customar()
            //{
            //    Id = id,
            //    Name = name
            //};
            DBContext.customers.Add(new Customar { Id = id, Name = name });
            return RedirectToAction("Display");
        }
        public JsonResult Display()
        {
            return Json(DBContext.customers, JsonRequestBehavior.AllowGet);
        }

    }
}