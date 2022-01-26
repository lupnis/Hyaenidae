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

        #region Message Classes
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
            public JsonDocument Message { get; set; }
        }
        private class NumpyMessage
        {
            public string Name => GlobalData.Name;
            public string SubName => GlobalData.SubName;
            public string Version => GlobalData.Version;
            public string Notes { get; set; }
            public JsonDocument Message { get; set; }
        }
        #endregion

        #region API interfaces for test and normal information access
        [HttpGet]
        [Route("/Api")]
        [Route("/Api/Test")]
        public string Test()
        {
            return JsonSerializer.Serialize(new TextMessage { Message = "Done." });
        }

        [HttpGet]
        [Route("/Api/Hyaenidae")]
        public string Hello()
        {
            return JsonSerializer.Serialize(new TextMessage { Message = "Hello, this is little Aenidae at service!" });
        }
        [HttpGet]
        [Route("/Api/RemainDatasetIDRequests")]
        public int CountRequested()// temporarily unavailable
        {
            return 99999;
        }
        #endregion


        /*[HttpGet]
        [Route("/Api/OLAC/Dataset/{reqid}")]//online access dataset details
        [Route("/Api/OLAC/Datasets/{reqid}")]
        public string OLAC_Dataset_Intr(string reqid)
        {
            return JsonSerializer.Serialize(new TextMessage { Message = "Intr:reqid=" + reqid });
            //TODO:
        }

        [HttpGet]
        [Route("/Api/OLAC/Dataset/{reqid}/{didx}")]//online access
        [Route("/Api/OLAC/Datasets/{reqid}/{didx}")]
        public string OLAC_DatasetAccess_General(string reqid, ulong didx)
        {
            switch (reqid[0])
            {
                case 'B':
                    return OLAC_DatasetAccess_Trans2Binary(reqid, didx);
                case 'T':
                    return OLAC_DatasetAccess_Trans2Tensor(reqid, didx);
                case 'N':
                    return OLAC_DatasetAccess_Trans2Numpy(reqid, didx);
                case 'I':
                    return OLAC_DatasetAccess_Trans2Image(reqid, didx);
            }
            return JsonSerializer.Serialize(new TextMessage { Message = "reqid=" + reqid + ", didx=" + didx });
            //TODO:
        }
        public string OLAC_DatasetAccess_Trans2Binary(string reqid, ulong didx)
        {
            return JsonSerializer.Serialize(new TextMessage { Message = "[BIN]reqid=" + reqid + ", didx=" + didx });
            //TODO:
        }
        public string OLAC_DatasetAccess_Trans2Tensor(string reqid, ulong didx)
        {
            return JsonSerializer.Serialize(new TextMessage { Message = "[Tensor]reqid=" + reqid + ", didx=" + didx });
            //TODO:
        }
        public string OLAC_DatasetAccess_Trans2Numpy(string reqid, ulong didx)
        {
            return JsonSerializer.Serialize(new TextMessage { Message = "[Numpy]reqid=" + reqid + ", didx=" + didx });
            //TODO:
        }
        public string OLAC_DatasetAccess_Trans2Image(string reqid, ulong didx)
        {
            return JsonSerializer.Serialize(new TextMessage { Message = "[Image]reqid=" + reqid + ", didx=" + didx });
            //TODO:
        }*/

    }
}
