public class Solution {
    public int FindPeakElement(int[] nums) {
        if (nums.Length == 1) return 0;

        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var mid = left + (right - left) / 2;

            // Console.WriteLine($"{left}|{right}->{mid}");

            if (mid != 0 && mid != nums.Length - 1)
            {
                if (nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
                {
                    return mid;
                }
                else if (nums[mid] > nums[mid - 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            else // if (mid == 0)
            {
                if (nums[mid] > nums[mid + 1]) return mid;
                else left = mid + 1;
            }
        }

        return left;
    }
}