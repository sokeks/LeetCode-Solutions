public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var left = 0;
        var right = nums.Length;

        while (left < right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] > target)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }
}