using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovaya.Models
{
    public class BrandContext:DbContext
    {
        public DbSet<BikeBrandsDB> Brands{ get; set; }
        public BrandContext(DbContextOptions<BrandContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
