using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hyaenidae.Controllers
{
    [ApiController]
    public class DatasetsApiController : ControllerBase
    {
        [HttpGet]
        [Route("/Api")]
        [Route("/Api/Test")]
        public string Test()
        {
            return "service temporarily unavailable";
        }
        [HttpGet]
        [Route("/Api/Hyaenidae")]
        public string Hello()
        {
            return "Hello, this is Hyaenidae at service!";
        }
    }
}
