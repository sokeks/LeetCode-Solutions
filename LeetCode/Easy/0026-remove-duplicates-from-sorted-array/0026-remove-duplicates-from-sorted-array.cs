public class Solution {
    // design-by-contract coding - no defensive guard-ifs
    public int RemoveDuplicates(int[] nums) {
        var insertIdx = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[insertIdx] = nums[i];
                insertIdx++;
            }
        }

        return insertIdx;
    }
}