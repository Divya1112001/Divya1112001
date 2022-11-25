using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Project3.Models;

namespace Project3.Models
{
    public class ManagerContext : DbContext
    {
        public ManagerContext(): base("name=Manager")
        {

        }
        public DbSet<Employee> Managers { get; set; }
    }
}
