public class Solution {
    public void MoveZeroes(int[] nums) {
        var insertIdx = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                if (insertIdx != i)
                {
                    nums[insertIdx] = nums[i];
                }
                insertIdx++;
            }
        }
        
        for (var i = insertIdx; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}