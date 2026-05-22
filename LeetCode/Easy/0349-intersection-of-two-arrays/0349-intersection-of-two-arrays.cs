public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        Span<byte> occurred = stackalloc byte[1001];

        foreach (var i in nums1.AsSpan())
        {
            occurred[i] = 1;
        }

        var inter = new int[Math.Min(nums1.Length, nums2.Length)];
        var ptr = 0;
        foreach (var i in nums2.AsSpan())
        {
            if (occurred[i] == 1)
            {
                occurred[i] += 1;
                inter[ptr++] = i;
            }
        }

        return inter[..ptr];
    }
}