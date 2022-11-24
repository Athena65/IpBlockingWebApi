using IpBlockingWebApi.Filters;
using Microsoft.AspNetCore.Mvc;

namespace IpBlockingWebApi.Controllers
{
    [Route("[action]")]
    [ApiController]
    public class IpBlockController : ControllerBase
    {
        [HttpGet("unblocked")]
        public string Unblocked()
        {
            return "Unblocked access";
        }



        [ServiceFilter(typeof(IpBlockActionFilter))]
        [HttpGet("blocked")]
        public string Blocked()
        {
            return "Blocked access";
        }

     
    }
}
