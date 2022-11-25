using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using Project3.Models;

namespace Project3.Controllers
{
    public class ManagerController : Controller
    {
        ManagerContext mc = new ManagerContext();
        // GET: Manager
        public ActionResult Index()
        {
            return View(mc.Managers.ToList());
        }
        [HttpGet]
        public ActionResult Details()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Details (Employee manager)
        {
            mc.Managers.Add(manager);
            mc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
