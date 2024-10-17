using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw1_wpf.Models
{
    public class Nwd
    {
        public static int NwdRec(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return NwdRec(b, a % b);
        }
        public static int NwdIter(int a, int b)
        {
            while (b != 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }
            return a;
        }
    }
}
