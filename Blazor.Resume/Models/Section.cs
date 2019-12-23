using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Resume.Models
{
    public class Section
    {
        public SectionType Type { get; set; }
        public List<Comment> Comments { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public List<Section> Subsections { get; set; } = null;
    }

    public enum SectionType
    {
        comment,
        section
    }
}
