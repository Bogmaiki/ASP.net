using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TheGenerics.Data
{
    public class TheGenericsContext : DbContext
    {
        public TheGenericsContext (DbContextOptions<TheGenericsContext> options)
            : base(options)
        {
        }

        public DbSet<Tour> Tour { get; set; } = default!;
    }
}
