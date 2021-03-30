using System;

namespace WEBASPDOTNETCOREMVC_BootstrapConsumeAPI_Equipment.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
