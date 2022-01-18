/*under sonstricution*/
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Hyaenidae.Models;

namespace Hyaenidae.Controllers
{
    public class ArchiveController : Controller
    {
        public IActionResult Index()
        {
            return View(new ArchiveViewModel { pageID= int.Parse(HttpContext.Request.Query["page"].FirstOrDefault()==null?"1": HttpContext.Request.Query["page"].FirstOrDefault()) });
        }
        public IActionResult Search()
        {
            return View();
        }
    }
}
