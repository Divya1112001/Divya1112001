using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginAndManager.Models;

namespace LoginAndManager.Controllers
{
    public class ManagerController : Controller
    {
        EmployeetravelsystemEntities db = new EmployeetravelsystemEntities();

        // GET: Manager
        static List<Employee_tbl> Employees = new List<Employee_tbl>();
        public ActionResult Index()
        {
            return View(Employees);
        }
        public ActionResult Details(Employee_tbl employee)
        {
            Employees.Add(employee);
            return View("Details", employee);
        }
    }
}
