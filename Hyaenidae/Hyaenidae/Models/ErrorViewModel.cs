using System;

namespace Hyaenidae.Models
{
    public class ErrorViewModel
    {

        public string RequestId { get; set; }
        public int ErrorCode { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
