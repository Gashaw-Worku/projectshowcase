using ShowCase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowCase.Domain.Abstract
{
    public interface IThemeRepository
    {
        IEnumerable<Theme> Themes { get; }
    }
}
