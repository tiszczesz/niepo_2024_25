using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2.Models
{
    public class Animal
    {
        public int Id { get; set; }

        [DisplayName("Nazwa")]
        public string? Name { get; set; }

        [DisplayName("Gatunek")]
        public string? Species { get; set; }

        [DisplayName("Wiek")]
        public int? Age { get; set; }

        [DisplayName("Masa")]
        public double? Weight { get; set; }
    }
}
