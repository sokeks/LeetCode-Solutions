public class Solution {
    public int LongestOnes(int[] nums, int k) {
        var left = 0;
        var right = 0;

        for (; right < nums.Length; right++)
        {
            if (nums[right] == 0) k--;

            if (k < 0)
            {
                if (nums[left] == 0) k++;
                left++;
            }
        }

        return right -  left;
    }
}