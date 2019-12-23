using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Resume.Models
{
    public class Settings
    {
        public string ApiBaseUrl { get; set; }
        public string ApiContact { get; set; }
        public bool DynamicContact { get; set; }
        public string MailAddressForStaticContactPage { get; set; }
        public string Author { get; set; }
    }
}
