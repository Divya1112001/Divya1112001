using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEB_API_EF.Models;

namespace WEB_API_EF.Controllers
{
    public class EmpController : ApiController
    {
        EmployeetravelsystemEntities1 db = new EmployeetravelsystemEntities1();
        //Get
        public IEnumerable<Employee_tbl>Get()
        {
            return db.Employee_tbl.ToList();
        }
        //post
        //public IHttpActionResult Index()
        //{
        //    Employee_tbl Et = new Employee_tbl();
        //    return View(Et);
        //}

       
    }
}
