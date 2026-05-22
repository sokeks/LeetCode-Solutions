public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        var closestTarget = nums[0] + nums[1] + nums[2];

        for (var ii = 0; ii < nums.Length - 2; ii++)
        {
            var frozen = nums[ii];
            if (ii != 0 && frozen == nums[ii - 1])
            {
                continue;
            }

            var left = ii + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = frozen + nums[left] + nums[right];
                closestTarget = (Math.Abs(target - sum) < Math.Abs(target - closestTarget))
                    ? sum
                    : closestTarget;

                if (closestTarget == target)
                {
                    return closestTarget;
                }
                else if (sum > target)
                {
                    while (left < right && nums[right - 1] == nums[right]) right--;
                    right--;
                }
                else
                {
                    while (left < right && nums[left + 1] == nums[left]) left++;
                    left++;
                }
            }
        }
        return closestTarget;
    }
}