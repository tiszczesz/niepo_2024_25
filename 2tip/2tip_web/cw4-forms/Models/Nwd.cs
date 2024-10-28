using System;

namespace cw4_forms.Models;

public class Nwd
{
    public int A { get; set; }
    public int B { get; set; }
    public int NwdRec(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return NwdRec(b, a % b);
        }
    }
}
