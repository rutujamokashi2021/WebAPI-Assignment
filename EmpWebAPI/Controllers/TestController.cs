
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Security.Claims;

namespace EmpWebAPI.Controllers
{
    public class TestController : ApiController
    {
        [Authorize(Roles = " Admin, User")]
        [HttpGet]
        [Route("api/test/method1")]
        public HttpResponseMessage Post(PropertiesClass myclass)
        {
            var identity = (ClaimsIdentity)User.Identity;
            var roles = identity.Claims
                        .Where(c => c.Type == ClaimTypes.Role)
                        .Select(c => c.Value);

            myclass.Role = roles.ToString();
            myclass.Name = identity.Name;

            return Request.CreateResponse(HttpStatusCode.Created, myclass);
        }
    }
}
