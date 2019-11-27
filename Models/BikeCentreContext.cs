using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovaya.Models
{
    public class BikeCentreContext:DbContext
    {
        public DbSet<BikeModelDB> BikeModelDBs { get; set; }
        public DbSet<BrakesDB> BrakesDBs { get; set; }
        public DbSet<BrandsDB> BrandsDBs { get; set; }
        public DbSet<GenderDB> GenderDBs { get; set; }
        public DbSet<TypeBikesDB> TypeBikesDBs { get; set; }
        public DbSet<TypeOfBrakesDB> TypeOfBrakesDBs { get; set; }
        public BikeCentreContext(DbContextOptions<BikeCentreContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
