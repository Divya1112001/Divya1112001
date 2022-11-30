using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using WEB_API_EF.Models;
using System.Web.Http;
using System.Web.Mvc;
using WEB_API_EF.Models;

namespace WEB_API_EF.Controllers
{
    public class UserController : ApiController
    {
        EmployeetravelsystemEntities1 db = new EmployeetravelsystemEntities1();
        public IEnumerable<User> Get()
        {
            return db.Users.ToList();
        }
       
        public string Index(User us)
        {
            var display = db.Users.Where(m => m.User_id == us.User_id && m.User_Name == us.User_Name && m.pwd == us.pwd).FirstOrDefault();
            if (display != null)
            {
                return "CORRECT UserNAme and Password";
            }
            else
            {
                return "INCORRECT UserName or Password";
            }
            
        }
    }

}
