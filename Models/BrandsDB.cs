using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovaya.Models
{
    public class BrandsDB
    {
        [Key]
        public int ID_Brand { get; set; }
        public string BrandName { get; set; }
        public string SiteBrand { get; set; }
        public string CountryBrand { get; set; }


    }
}
