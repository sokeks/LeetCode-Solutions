public class Solution {
    public int Tribonacci(int n) {
        var t0 = 0;
        var t1 = 1;
        var t2 = 1;

        if (n == 0) return t0;
        if (n == 1) return t1;
        if (n == 2) return t2;

        for (var i = 0; i < n - 2; i++) (t0, t1, t2) = (t1, t2, t0 + t1 + t2);

        return t2;
    }
}