using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrialMvc.Models;

namespace TrialMvc.Controllers
{
    public class TrialController : Controller
    {
        public ViewResult AllEmployees()
        {
            var context = new TrialllEntities();
            var model = context.MyTables.ToList();
            return View(model);
        }

        public ViewResult Find(string id)
        {
            int empId = int.Parse(id);
            var context = new TrialllEntities();
            var model = context.MyTables.FirstOrDefault((e) => e.Id == empId);
            return View(model);

        }
        //ActionResult is the abstract class for all kinds of action returns....
        [HttpPost]
        public ActionResult Find(MyTable emp)
        {
            var context = new TrialllEntities();
            var model = context.MyTables.FirstOrDefault((e) => e.Id == emp.Id);
            model.Name= emp.Name;
            //model.EmpAddress = emp.EmpAddress;
            //model.EmpSalary = emp.EmpSalary;
            context.SaveChanges();//Commits the changes made to the records...
            return RedirectToAction("AllEmployees");
        }

        public ViewResult NewEmployee()
        {
            var model = new MyTable();//No Values in it...
            return View(model);
        }

        [HttpPost]
        public ActionResult NewEmployee(MyTable emp)
        {
            var context = new TrialllEntities();
            context.MyTables.Add(emp);
            context.SaveChanges();
            return RedirectToAction("AllEmployees");
        }

        public ActionResult Delete(string id)
        {
            //convert string to int
            int empId = int.Parse(id);
            var context = new TrialllEntities();
            var model = context.MyTables.FirstOrDefault((e) => e.Id == empId);
            context.MyTables.Remove(model);
            context.SaveChanges();
            return RedirectToAction("AllEmployees");
        }
    }
}