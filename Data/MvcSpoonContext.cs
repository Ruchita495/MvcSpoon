using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSpoon.Data
{
    public class MvcSpoonContext : DbContext
    {
        public MvcSpoonContext(DbContextOptions<MvcSpoonContext> options)
            : base(options)
        {
        }

        public DbSet<Spoon> Spoon{ get; set; }
    }
}
