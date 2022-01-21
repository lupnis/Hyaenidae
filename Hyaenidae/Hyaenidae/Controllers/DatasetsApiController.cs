using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hyaenidae.Controllers
{
    public class DatasetsApiController : ControllerBase
    {
        // GET: DatasetsApiController
        public string Index()
        {
            return "service temporarily unavailable";
        }

        // GET: DatasetsApiController/Details/5
        public string Details(int id)
        {
            return "service temporarily unavailable";
        }

        // GET: DatasetsApiController/Create
        public string Create()
        {
            return "service temporarily unavailable";
        }

        // POST: DatasetsApiController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public string Create(IFormCollection collection)
        {
            return "service temporarily unavailable";
        }

        // GET: DatasetsApiController/Edit/5
        public string Edit(int id)
        {
            return "service temporarily unavailable";
        }

        // POST: DatasetsApiController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public string Edit(int id, IFormCollection collection)
        {
            return "service temporarily unavailable";
        }

        // GET: DatasetsApiController/Delete/5
        public string Delete(int id)
        {
            return "service temporarily unavailable";
        }

        // POST: DatasetsApiController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public string Delete(int id, IFormCollection collection)
        {
            return "service temporarily unavailable";
        }
    }
}
