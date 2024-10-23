using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Random = System.Random;

namespace cw11_listbox.Models
{
    public class Numbers
    {
        public List<int> MyNumbers { get; set; }

        public Numbers(int size=20) {
           MyNumbers = new List<int>();
           Random rnd = new Random();
            for (int i = 0; i < size; i++) {
                MyNumbers.Add(rnd.Next(100));
            }
        }

        public int GetMax() {
            return MyNumbers.Max();
        }
    }
}
