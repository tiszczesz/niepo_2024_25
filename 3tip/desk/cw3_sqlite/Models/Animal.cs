using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw3_sqlite.Models
{
    public  class Animal
    {
        public int Id { get; set; }

        [DisplayName("Nazwa")]
        public string? Name { get; set; }

        [DisplayName("Gatunek")]
        public string? Species { get; set; }

        [DisplayName("Data urodzenia")]
        public DateOnly BitrhDay { get; set; }

    }
}
