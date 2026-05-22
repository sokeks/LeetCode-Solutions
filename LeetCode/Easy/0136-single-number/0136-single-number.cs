public class Solution {
    public int SingleNumber(int[] nums) {
        int xorSum = 0;
        foreach (var n in nums)
        {
            // XORing a number with itself cancels it out. Only the single number remains.
            xorSum ^= n;
        }

        return xorSum;
    }
}