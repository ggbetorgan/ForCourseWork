using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovaya.Models
{
    public class TypeBikesDB:DbContext
    {
        public int ID_TypeBikes { get; set; }
        public string TypeBikesName { get; set; }
        public string TypeBikesComment { get; set; }
    }
}
