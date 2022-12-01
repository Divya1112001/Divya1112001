
namespace Authentication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee_tbl
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
    
        public virtual Dept_tbl Dept_tbl { get; set; }
        public virtual Project_tbl Project_tbl { get; set; }
    }
}
