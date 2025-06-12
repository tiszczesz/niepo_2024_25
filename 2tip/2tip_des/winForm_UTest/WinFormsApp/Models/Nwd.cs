using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Models
{
    public class Nwd
    {
        public static int NwdRec(int a, int b) {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (b == 0) return a;
            return NwdRec(b, a % b);
        }

        public static int NwdIter(int a, int b) {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (b == 0) return a;
            while (b != 0) {
                int temp = a;
                a = b;
                b = temp % a;
            }
            return a;
        }
    }
}
