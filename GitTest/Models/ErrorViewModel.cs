using System;

namespace GitTest.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public int Number { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
