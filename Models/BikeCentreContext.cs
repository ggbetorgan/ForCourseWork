using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovaya.Models
{
    public class BikeCentreContext:DbContext
    {
        public DbSet<BikeModelDB> DBBikesModels { get; set; }
        public DbSet<BrakesDB> DBBrakes { get; set; }
        public DbSet<BrandsDB> DBBrands { get; set; }
        public DbSet<GenderDB> DBGender { get; set; }
        public DbSet<TypeBikesDB> DBTypeBikes{ get; set; }
        public DbSet<TypeOfBrakesDB> DBTypeOfBrakes { get; set; }
        public BikeCentreContext(DbContextOptions<BikeCentreContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
