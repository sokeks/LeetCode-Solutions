public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        var min = int.MaxValue;
        var mid = int.MaxValue;

        foreach (var n in nums)
        {
            if (n <= min)
            {
                min = n;
            }
            else if (n <= mid)
            {
                mid = n;
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}