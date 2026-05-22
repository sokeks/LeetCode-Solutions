public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        var currentSum = 0;
        for (var i = 0; i < k; i++)
        {
            currentSum += nums[i];
        }


        var maxSum = currentSum;
        for (var i = k; i < nums.Length; i++)
        {
            currentSum += (-nums[i - k] + nums[i]);
            if (currentSum > maxSum) maxSum = currentSum;
        }

        return (double)maxSum / k;
    }
}