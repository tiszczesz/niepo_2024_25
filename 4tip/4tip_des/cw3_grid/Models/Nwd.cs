namespace cw3_grid.Models;

public class Nwd {
    public static int Run(int a, int b) {
        if (b == 0) return a;
        return Run(b, a % b);
    }
}