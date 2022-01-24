using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;
using System.Drawing;
using Hyaenidae.Misc;

namespace Hyaenidae.Controllers
{
    [ApiController]
    public class DatasetsApiController : ControllerBase
    {
        private class TextMessage
        {
            public string Name => GlobalData.Name;
            public string SubName => GlobalData.SubName;
            public string Version => GlobalData.Version;
            public GlobalData.ServerStatus Status => GlobalData.Status;
            public double UpTime => Math.Round((DateTime.Now - GlobalData.Activated).TotalMinutes);
            public String Message { get; set; }
        }
        private class PlainTextMessage
        {
            public string Name => GlobalData.Name;
            public string SubName => GlobalData.SubName;
            public string Version => GlobalData.Version;
            public string Notes { get; set; }
            public String Message { get; set; }
        }
        private class ImageMessage
        {
            public string Name => GlobalData.Name;
            public string SubName => GlobalData.SubName;
            public string Version => GlobalData.Version;
            public string Notes { get; set; }
            public Image Message { get; set; }
        }
        private class BinaryMessage
        {
            public string Name => GlobalData.Name;
            public string SubName => GlobalData.SubName;
            public string Version => GlobalData.Version;
            public string Notes { get; set; }
            public Byte[] Message { get; set; }
        }
        private class TensorMessage
        {
            public string Name => GlobalData.Name;
            public string SubName => GlobalData.SubName;
            public string Version => GlobalData.Version;
            public string Notes { get; set; }
            public List<List<Object>> Message { get; set; }
        }

        [HttpGet]
        [Route("/Api")]
        [Route("/Api/Test")]
        public string Test()
        {
            return JsonSerializer.Serialize(new TextMessage { Message="Done."});
        }

        [HttpGet]
        [Route("/Api/Hyaenidae")]
        public string Hello()
        {
            return JsonSerializer.Serialize(new TextMessage { Message = "Hello, this is little Aenidae at service!" });
        }
        [HttpGet]
        [Route("/Api/RemainDatasetIDRequests")]
        public int CountRequested()
        {
            return 0x3f3f3f3f;
        }
    }
}
