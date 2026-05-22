public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        var results = new List<IList<int>>();
        for (var ii = 0; ii < nums.Length - 2; ++ii)
        {
            if (ii != 0 && nums[ii] == nums[ii - 1])
            {
                continue;
            }

            var frozen = nums[ii];
            var left = ii + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = frozen + nums[left] + nums[right];
                if (sum == 0)
                {
                    results.Add(new List<int>() {frozen, nums[left], nums[right]});
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;
                    left++;
                    right--;
                }
                else if (sum > 0)
                {
                    --right;
                }
                else
                {
                    ++left;
                }
            }
        }

        return results;
    }
}