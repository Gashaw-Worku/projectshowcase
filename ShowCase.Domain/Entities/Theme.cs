using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowCase.Domain.Entities
{
    public class Theme
    {
        public int ThemeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MoreLinkInfo { get; set; }
    }
}
