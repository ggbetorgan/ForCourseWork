using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovaya.Models
{
    public class CostBike
    {
            public string[] getBrandsName()
            {
                string[] BrandsName = { "Stels", "Mongoose", "DE" };
                return BrandsName;
            }

            public int l { get; set; } //бренд
            public int m { get; set; } //размер колес

            public double GetCost() // вычисление стоимости
            {
                return Math.Pow(m, 2) * 10 + 12000;
            }

    }
}
