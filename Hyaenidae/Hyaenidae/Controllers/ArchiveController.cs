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
            return View(new ArchiveViewModel { PageID = 1 ,TotalPages=1 ,currentPage=1}) ;
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
