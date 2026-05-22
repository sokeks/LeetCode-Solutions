public class Solution {
    public bool IsUgly(int n) {
        if (n <= 0) return false;

        ReadOnlySpan<int> uglyPrimes = stackalloc int[] { 2, 3, 5 };
        foreach (var uglyPrime in uglyPrimes)
        {
            while (n % uglyPrime == 0)
            {
                n /= uglyPrime;
            }
        }

        return n == 1;
    }
}