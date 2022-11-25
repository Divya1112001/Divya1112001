using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.Models
{
    public class Employee
    {
        [Key]
        public int empid { get; set; }
        [Required]
        public string empname { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        public string gender { get; set; }
        public string password { get; set; }
        [Required]
        public string projectid { get; set; }
        public string deptid { get; set; }
        public string empdesignation { get; set; }
        [Required]
        public int phone { get; set; }
        [Required]
        public DateTime DOJ { get; set; }
        public string reportmanager { get; set; }
        [Required]
        public int salary { get; set; }

    }
}
