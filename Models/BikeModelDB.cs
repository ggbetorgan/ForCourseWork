using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovaya.Models
{
    public class BikeModelDB
    {
        [Key]
        public int ID_BikeModel { get; set; }
        public int Brand_ID { get; set; }
        public int Brakes_ID { get; set; }
        public int Gender_ID { get; set; }
        public float WarrantyPeriod { get; set; }
        public int Price { get; set; }
        public string NameModelBike { get; set; }
        public string TechnicalParameters { get; set; }
        public int TypeBike_ID { get; set; }
    }
}
