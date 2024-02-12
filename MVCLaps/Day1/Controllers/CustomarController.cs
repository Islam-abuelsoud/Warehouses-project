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
            DBContext.customers.Add(new Customar { Id = id, Name = name });
            return RedirectToAction("Display");
        }
        public JsonResult Display()
        {
            return Json(DBContext.customers, JsonRequestBehavior.AllowGet);
        }
        public RedirectToRouteResult Update(int Id, string Name)
        {
            var employeeToUpdate = DBContext.customers.First(e => e.Id == Id);
            employeeToUpdate.Name = Name;

            return RedirectToAction("Display");
        }
        public RedirectToRouteResult Delete(int Id)
        {
            var employeeToDelete = DBContext.customers.First(e => e.Id == Id);
            DBContext.customers.Remove(employeeToDelete);
            return RedirectToAction("Display");
        }

    }
}