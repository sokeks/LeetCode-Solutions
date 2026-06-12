public class Solution {
    public int FindPeakElement(int[] nums) {
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var mid = left + (right - left) / 2;
            if (nums[mid] > nums[mid + 1])
            {
                if (mid == 0 || nums[mid] > nums[mid - 1]) return mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }
}