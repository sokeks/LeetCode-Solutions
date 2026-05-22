public class Solution {
    public int MajorityElement(int[] nums) {
        var candidate = 0;
        var counter = 0;

        foreach (var n in nums)
        {
            if (counter == 0)
            {
                candidate = n;
            }

            counter += (n == candidate) ? 1 : -1; 
        }

        return candidate;
    }
}