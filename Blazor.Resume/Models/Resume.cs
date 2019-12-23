using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Resume.Models
{
    public class Resume
    {
        public List<Section> Sections { get; set; }
        public Settings Settings { get; set; }
        public List<Link> Links { get; set; }
    }
}
