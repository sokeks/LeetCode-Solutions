public class Solution {
    public int MissingNumber(int[] nums) {
        var missing = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            missing ^= (i + 1) ^ nums[i]; // a XOR a = 0 -> missing number detector
        }

        return missing;
    }
}