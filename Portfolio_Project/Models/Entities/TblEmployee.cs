using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio_Project.Models.Entities
{
    public class TblEmployee
    {
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeSurname { get; set; }

        public string EmployeeCity { get; set; }

        public Nullable<decimal> EmployeeSalary { get; set; }

        public Nullable<int> EmployeeDepartment { get; set; }
    }
}