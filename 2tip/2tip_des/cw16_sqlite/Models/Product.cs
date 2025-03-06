using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw16_sqlite.Models
{
    public class Product
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nazwa")]
        public string Name { get; set; }

        [DisplayName("Opis")]
        public string? Description { get; set; }

        [DisplayName("Cena")]
        public decimal Price { get; set; }
      
    }
}
