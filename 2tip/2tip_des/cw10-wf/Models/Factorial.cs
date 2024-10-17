using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw10_wf.Models
{
    public class Factorial
    {
        public int N { get; set; }
        public double ResultIter()
        {
            double result = 1;
            for (int i = 1; i <= N; i++)
            {
                result *= i;
            }
            return result;
        }
        public double ResultRec(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * ResultRec(n - 1);
        }
    }
}
