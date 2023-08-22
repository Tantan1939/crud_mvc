using CRUD_OperationsInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_OperationsInMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeDBContext dbContext = new EmployeeDBContext();
            List<Employee> emplist = dbContext.Employees.ToList();
            return View(emplist);
        }

        public ActionResult notifbar()
        {
            return View();
        }
    }
}