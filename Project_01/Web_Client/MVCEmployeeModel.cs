using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day1_client.Models
{
    public class MVCEmployeeModel
    {
        public int Emp_id { get; set; }
        public string Emp_Name { get; set; }
        public string Email { get; set; }
        public System.DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public Nullable<int> Project_id { get; set; }
        public Nullable<int> Dept_id { get; set; }
        public string Emp_designation { get; set; }
        public string Phone { get; set; }
        public System.DateTime DOJ { get; set; }
        public string Report_manager { get; set; }
        public Nullable<int> salary { get; set; }
        public string status { get; set; }
    }
}
