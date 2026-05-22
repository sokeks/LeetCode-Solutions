public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);

        List<IList<int>> results = new List<IList<int>>();

        for (var ii = 0; ii < nums.Length - 3; ii++)
        {
            if ((long)nums[ii] + nums[ii + 1] + nums[ii + 2] + nums[ii + 3] > target) break;
            if ((long)nums[ii] + nums[nums.Length-1] + nums[nums.Length-2] + nums[nums.Length-3] < target) continue;

            if (ii != 0 && nums[ii] == nums[ii - 1])
            {
                continue;
            }
            for (var jj = ii + 1; jj < nums.Length - 2; jj++)
            {
                if (jj != ii + 1 && nums[jj] == nums[jj - 1])
                {
                    continue;
                }

                var left = jj + 1;
                if ((long)nums[ii] + nums[jj] + nums[jj + 1] + nums[jj + 2] > target) break;

                var right = nums.Length - 1;
                if ((long)nums[ii] + nums[jj] + nums[nums.Length - 2] + nums[nums.Length - 1] < target) continue;

                while (left < right)
                {
                    var sum = (long)nums[ii] + nums[jj] + nums[left] + nums[right];
                    if (sum == target)
                    {
                        results.Add(new List<int>() { nums[ii], nums[jj], nums[left], nums[right]} );
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;

                        left++;
                        right--;
                    }
                    else if(sum > target)
                    {
                        right--;
                    }
                    else
                    {
                        left++;
                    }
                }
            }
        }


        return results;
    }
}