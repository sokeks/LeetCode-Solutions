

public class Solution {
    public int PivotIndex(int[] nums)
        => PivotIndex(nums.AsSpan(), nums.Sum());

    private int PivotIndex(ReadOnlySpan<int> nums, int totalSum)
    {
        var leftSum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (leftSum == (totalSum - nums[i] - leftSum))
            {
                return i;
            }
            
            leftSum += nums[i];
        }

        return -1;
    }
}