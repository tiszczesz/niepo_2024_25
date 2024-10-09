using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw10_wf.Models
{
    public class Numbers
    {
        public int A { get; set; }
        public int B { get; set; }
        public double Result(char choice = '+'){
            switch (choice) {
                case '+':
                    return A + B;
                case '-':
                    return A - B;
                case '*':
                    return A * B;
                case '/':
                    return B!=0 ? A / B: -9.99999;
                default:
                    return A + B;
            }
        }
    }
}
