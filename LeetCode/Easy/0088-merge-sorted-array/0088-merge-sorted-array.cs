public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        var r = m + n - 1;
        m--;
        n--;
        while (n >= 0 && m >= 0)
        {
            if (nums1[m] > nums2[n])
            {
                nums1[r--] = nums1[m--];
            }
            else
            {
                nums1[r--] = nums2[n--];
            }
        }

        while (n >= 0) nums1[r--] = nums2[n--];


        // while (n >= 0)
        // {
        //     var result = m >= 0 && nums1[m] > nums2[n]
        //         ? nums1[m--]
        //         : nums2[n--];
        //     nums1[r] = result;
        //     r--;
        // }
    }
}