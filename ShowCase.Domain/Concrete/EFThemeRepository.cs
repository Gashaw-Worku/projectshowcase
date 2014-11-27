using ShowCase.Domain.Abstract;
using ShowCase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowCase.Domain.Concrete
{
    public class EFThemeRepository : IThemeRepository
    {
        private readonly EFDbContext context = new EFDbContext();

        public IEnumerable<Theme> Themes
        {
            get { return context.Themes; }
        }
    }
}
