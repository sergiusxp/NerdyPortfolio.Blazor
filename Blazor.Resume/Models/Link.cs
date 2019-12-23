using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Resume.Models
{
    public class Link
    {
        public string Label { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public bool IsBlank { get; set; } = true;
        public bool IsInternal { get; set; } = false;
    }
}
