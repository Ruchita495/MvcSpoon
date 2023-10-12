using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcSpoon.Models;

namespace MvcSpoon.Data
{
    public class MvcSpoonContext : DbContext
    {
        public MvcSpoonContext(DbContextOptions<MvcSpoonContext> options)
            : base(options)
        {
        }

        public DbSet<Spoons> Spoons { get; set; }
    }
}
