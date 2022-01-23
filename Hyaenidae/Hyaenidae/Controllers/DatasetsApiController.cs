using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;

using Hyaenidae.Misc;

namespace Hyaenidae.Controllers
{
    [ApiController]
    public class DatasetsApiController : ControllerBase
    {
        private class TestMessage
        {
            public string Name => GlobalData.Name;
            public string SubName => GlobalData.SubName;
            public string Version => GlobalData.Version;
            public GlobalData.ServerStatus Status => GlobalData.Status;
            public double UpTime => Math.Round((DateTime.Now - GlobalData.Activated).TotalMinutes);
        }
       /* [HttpGet]
        [Route("/Api/Switch")]
        public string Down()
        {
            GlobalServerOperation.SetServerStatus(GlobalData.ServerStatus.Down);
            return "ok";
        }*/
        [HttpGet]
        [Route("/Api")]
        [Route("/Api/Test")]
        public string Test()
        {
            return JsonSerializer.Serialize(new TestMessage());
        }
        [HttpGet]
        [Route("/Api/Hyaenidae")]
        public string Hello()
        {
            return "Hello, this is Hyaenidae at service!";
        }
        [HttpGet]
        [Route("/Api/RemainDatasetIDRequests")]
        public long CountRequested()
        {
            return 0x3f3f3f3f;
        }
    }
}
