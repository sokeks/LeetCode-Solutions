public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        var prev2 = 0;
        var prev1 = 0;

        for (var i = 2; i < cost.Length + 1; i++)
        {
            (prev2, prev1) = (prev1, Math.Min(prev1 + cost[i - 1], prev2 + cost[i - 2]));
        }

        return prev1;
    }
}