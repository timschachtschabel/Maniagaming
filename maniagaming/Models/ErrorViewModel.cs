using System;

namespace maniagaming.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        //test
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
