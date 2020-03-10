using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IpService.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IHttpContextAccessor _accessor;
        public HomeController(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        [HttpGet]
        [Route("")]
        public ActionResult<string> Index()
        {
            string ip = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            return ip;
        }
    }
}
