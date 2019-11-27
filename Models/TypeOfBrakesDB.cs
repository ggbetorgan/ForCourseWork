using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovaya.Models
{
    public class TypeOfBrakesDB
    {
        [Key]
        public int ID_TypeOfBrake { get; set; }
        public string TypeBrakesName { get; set; }
        public string TypeBrakesComment { get; set; }

        public List<BrakesDB> BrakesDB { get; set; }

    }
}
