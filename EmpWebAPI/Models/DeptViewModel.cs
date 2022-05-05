using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpWebAPI.Models
{
    public class DeptViewModel
    {
        public int DeptId
        {
            get;
            set;

        }
        public string DeptName
        {
            get;
            set;

        }
        
        public string SDate
        {
            get;
            set;

        }
        public string EDate
        {
            get;
            set;

        }
        public EmpViewModel EmpId
        {
            get;
            set;

        }
    }
}