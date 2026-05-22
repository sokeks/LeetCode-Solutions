public class Solution {
    // note 2 interviewer: n=45, so one could just generate a table of all the values and return table[n]
    public int ClimbStairs(int n) {
        var prev2 = 0;
        var prev1 = 1;
        var current = 0;

        for (var i = 1; i <= n; i++ )
        {
            current = prev1 + prev2;
            prev2 = prev1;
            prev1 = current;
        }

        return current;
    }
}