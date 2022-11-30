using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginAndManager.Models;

namespace LoginAndManager.Controllers
{
    public class LoginController : Controller
    {
        EmployeetravelsystemEntities db = new EmployeetravelsystemEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User userlogin)
        {
            var display = db.Users.Where(m => m.User_id == userlogin.User_id && m.User_Name == userlogin.User_Name && m.pwd == userlogin.pwd).FirstOrDefault();
            if (display != null)
            {
                ViewBag.Status = "CORRECT UserNAme and Password";
            }
            else
            {
                ViewBag.Status = "INCORRECT UserName or Password";
            }
            return View(userlogin);
        }

    }
}
