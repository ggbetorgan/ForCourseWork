using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovaya.Models
{
    public class BrakesDB
    {
        [Key]
        public int ID_Brakes { get; set; }
        public int Brand_ID { get; set; }
        public int TypeBrake_ID { get; set; }
        public string ModelBrake { get; set; }
        public string CommentToBrake { get; set; }
    }
}
