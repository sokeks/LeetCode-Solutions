public class Solution {
    public int ThirdMax(int[] nums) {
        int? firstMax = null;
        int? secondMax = null;
        int? thirdMax = null;

        foreach (var n in nums)
        {
            if (firstMax == null || firstMax < n)
            {
                thirdMax = secondMax;
                secondMax = firstMax;
                firstMax = n; 
            }
            else if (n != firstMax && (secondMax == null || secondMax < n))
            {
                thirdMax = secondMax;
                secondMax = n;
            }
            else if (n < secondMax && (thirdMax == null || thirdMax < n))
            {
                thirdMax = n;
            }
        }

        return thirdMax.HasValue
                ? thirdMax.Value
                : firstMax.Value;
    }
}