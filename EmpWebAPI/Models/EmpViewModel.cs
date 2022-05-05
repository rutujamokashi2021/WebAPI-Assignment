using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpWebAPI.Models
{
    public class EmpViewModel
    {
        public int EmpId
        {
            get;
            set;
        }
        public string  Name
        {
            get;
            set;

        }
        public string Dept
        {
            get;
            set;
        }
    }
}