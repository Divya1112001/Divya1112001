using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Authentication.Models;
using System.Threading;

namespace Authentication.Controllers
{
   // [BasicAuthentication]
    public class UserController : ApiController
    {
        //authentication at action/ method level
        [BasicAuthentication]
        public HttpResponseMessage Authenticate(string userName, string pwd) {
            string username = Thread.CurrentPrincipal.Identity.Name;
            var ulist = new UserBL().GetUsers();
            if (ulist.Where(a => a.User_Name == userName && a.Password == pwd).Count() > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "User Authenticated");

            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.Unauthorized, "Authentication failed");
            }
        }
            //public ActionResult Index()
            //{
            //    return View();
            //}
            //public ActionResult ProcessLogin(User user)
            //{
            // SecurityService securityService = new SecurityService();
            //EmployeetravelsystemEntities db = new EmployeetravelsystemEntities();

            //    if (db.IsValid(user))
            //    {
            //        return View("LoginSuccess", user);
            //    }
            //    else
            //    {
            //        return View("LoginFailure", user);
            //    }

            //}
            

        }

    }
