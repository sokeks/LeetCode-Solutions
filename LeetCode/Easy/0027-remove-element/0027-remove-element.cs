public class Solution {
    // design-by-contract coding - no defensive guard-ifs
    public int RemoveElement(int[] nums, int val) {
        var left = 0;
        var right = nums.Length;

        while (left < right)
        {
            if (nums[left] == val)
            {
                right--;
                nums[left] = nums[right];
            }
            else
            {
                left++;
            }
        }

        return right;
    }
}