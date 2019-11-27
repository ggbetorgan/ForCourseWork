using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kursovaya.Models
{
    public class GenderDB
    {
        [Key]
        public int ID_Gender { get; set; }
        public string NameGender { get; set; }

    }
}
