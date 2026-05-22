public class Solution {
    public bool IsPowerOfFour(int n)
        => n > 0 && (n & (n - 1)) == 0 && (n & 0x55555555) != 0;
}

// classic solution
// public class Solution {
//     public bool IsPowerOfFour(int n) {
//         if (n <= 0) return false;
//         while (n % 4 == 0) n /= 4;
//         return n == 1;
//     }
// }