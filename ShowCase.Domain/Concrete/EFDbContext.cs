using ShowCase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowCase.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Theme> Themes { get; set; }
    }
}
