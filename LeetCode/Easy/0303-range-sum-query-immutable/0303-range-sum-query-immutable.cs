public class NumArray {
    private readonly int[] prefix;

    public NumArray(int[] nums) {
        prefix = new int[nums.Length + 1];
        for (var i = 0; i < nums.Length; i++)
        {
            prefix[i + 1] = prefix[i] + nums[i];
        }
    }
    
    public int SumRange(int left, int right)
        => prefix[right + 1] - prefix[left];
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */