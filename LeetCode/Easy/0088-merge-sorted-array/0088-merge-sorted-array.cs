public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var r = m + n - 1;
        var i1 = m - 1;
        var i2 = n - 1;
        while (i1 >= 0 && i2 >= 0)
        {
            if (nums1[i1] > nums2[i2])
            {
                nums1[r--] = nums1[i1--];
            }
            else
            {
                nums1[r--] = nums2[i2--];
            }
        }

        while (i2 >= 0) nums1[r--] = nums2[i2--];
    }

    // Previous version, less readable and with arguments modifications, both in value and semantically (from count to index), better not to do that
    public void MergeOld(int[] nums1, int m, int[] nums2, int n) {
        var r = m + n - 1;
        m--;
        n--;

        while (n >= 0)
        {
            var result = m >= 0 && nums1[m] > nums2[n]
                ? nums1[m--]
                : nums2[n--];
            nums1[r] = result;
            r--;
        }
    }

}