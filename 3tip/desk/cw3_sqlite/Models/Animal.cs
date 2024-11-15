using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw3_sqlite.Models
{
    public  class Animal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Species { get; set; }
        public DateOnly BitrhDay { get; set; }

    }
}
