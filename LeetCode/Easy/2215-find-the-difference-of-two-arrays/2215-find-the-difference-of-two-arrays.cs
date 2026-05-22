public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var set1 = nums1.ToHashSet();
        var set2 = nums2.ToHashSet();
        
        set1.ExceptWith(nums2);
        set2.ExceptWith(nums1);

        return new IList<int>[] {set1.ToArray(), set2.ToArray()};
    }
}