using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmpWebAPI.Models;

namespace EmpWebAPI.Controllers
{
    public class EmpController : ApiController
    {
        public IHttpActionResult GetAllEmp()
        {
            IList<EmpViewModel> Emp = null;
            using (var ctx = new EmpDBEntites())
            {
                emp = ctx.Emp.Include("Emp").Select(sbyte=> new EmpViewModel())
                    {
                        EmpId = s.EmpId,
                        Name =s.Name,
                        Dept = s.Dept
                    }).ToList<EmpViewModel>();
            }
            object emp = null;
            if (emp.Count == 0)
            {
                return NotFound();
            }
            return Ok(emp);
        }

        private void ToList<T>()
        {
            //throw new NotImplementedException();
        }
    }
}
