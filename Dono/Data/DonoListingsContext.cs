using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dono.Models;

namespace Dono.Data
{   

    public class DonoListingsContext : DbContext
    {
        
            public DonoListingsContext(DbContextOptions<DonoListingsContext> options)
                : base(options)
            {
            }

            public DbSet<Listings> Listings { get; set; }
    }
}
