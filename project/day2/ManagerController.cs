using LoginAddManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginAddManager.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
       static List<ManagerModel> Employees = new List<ManagerModel>();
        public ActionResult Index()
        {
            return View(Employees);
        }

        public ActionResult Details (ManagerModel employee)
        {
            Employees.Add(employee);
            return View("Details", employee);
        }
    }
}
