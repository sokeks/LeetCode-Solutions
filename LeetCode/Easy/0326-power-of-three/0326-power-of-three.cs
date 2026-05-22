public class Solution {
    private const int biggestPowerOfThreeInt = 1162261467; 
    public bool IsPowerOfThree(int n)
        => n > 0 && biggestPowerOfThreeInt % n == 0;
}

// //classic solution
// public class Solution {
//     public bool IsPowerOfThree(int n) {
//         if (n <= 0) return false;
//         while (n % 3 == 0) n /= 3;
//         return n == 1;
//     }
// }