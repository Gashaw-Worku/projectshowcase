using ShowCase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShowCase.WebUI.Models
{
    public class ThemeListViewModel
    {
        public IEnumerable<Theme> Themes { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}