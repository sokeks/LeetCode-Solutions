public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var set = new HashSet<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (i > k)
            {
                set.Remove(nums[i - k - 1]);
            }
            if (!set.Add(nums[i]))
            {
                return true;
            }

        }

        return false;
    }

    // alternative
    public bool ContainsNearbyDuplicateDic(int[] nums, int k) {
        var dic = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (dic.TryGetValue(nums[i], out int lastIndex) && i - lastIndex <= k)
            {
                return true;
            }
            dic[nums[i]] = i;
        }

        return false;
    }
}