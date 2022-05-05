using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpWebAPI.Models
{
    public class SalaryViewModel
    {
        public int Id
        {
            get;
            set;
        }
        public int DeptId
        {
            get;
            set;
        }
        public DeptViewModel Dept
        {
            get;
            set;
        }

    }
}