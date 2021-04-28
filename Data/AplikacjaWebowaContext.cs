using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zad2;

namespace AplikacjaWebowa.Data
{
    public class AplikacjaWebowaContext : DbContext
    {
        public AplikacjaWebowaContext (DbContextOptions<AplikacjaWebowaContext> options)
            : base(options)
        {
        }

        public DbSet<Zad2.Currency> Currency { get; set; }
    }
}
