public class Solution {
    public int LongestSubarray(int[] nums) {
        var left = 0;
        var right = 0;
        var budget = 1;

        for (; right < nums.Length; right++)
        {
            if (nums[right] == 0)
            {
                budget--;
            }

            if (budget < 0)
            {
                if (nums[left] == 0) budget++;
                left++;
            }
        }

        var length = right - left;

        return right - left - 1;
        
    }
}