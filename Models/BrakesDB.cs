using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovaya.Models
{
    public class BrakesDB
    {
        public int ID_Brakes { get; set; }
        public int Brand_ID { get; set; }
        public int TypeBrake_ID { get; set; }
        public string ModelBrake { get; set; }
        public string CommentToBrake { get; set; }
    }
}
