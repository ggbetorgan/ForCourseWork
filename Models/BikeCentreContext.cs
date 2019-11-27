using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovaya.Models
{
    public class BikeCentreContext:DbContext
    {
        public DbSet<BikeModelDB> BikeModelDB { get; set; }
        public DbSet<BrakesDB> BrakesDB { get; set; }
        public DbSet<BrandsDB> BrandsDB { get; set; }
        public DbSet<GenderDB> GenderDB { get; set; }
        public DbSet<TypeBikesDB> TypeBikesDB { get; set; }
        public DbSet<TypeOfBrakesDB> TypeOfBrakesDB { get; set; }
        public BikeCentreContext(DbContextOptions<BikeCentreContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
