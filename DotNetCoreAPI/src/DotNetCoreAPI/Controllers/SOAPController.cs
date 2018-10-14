using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreAPI.Controllers
{
    [Route("api/[controller]")]
    public class SOAPController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "You are at the SOAP controller";
        }
    }
}
