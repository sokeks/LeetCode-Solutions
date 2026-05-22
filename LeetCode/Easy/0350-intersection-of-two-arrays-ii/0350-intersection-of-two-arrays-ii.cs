public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Span<short> occurred = stackalloc short[1001];
        
        foreach (var n in nums1.AsSpan())
        {
            occurred[n] += 1;
        }

        var inter = new int[Math.Min(nums1.Length, nums2.Length)];
        var p = 0;
        foreach (var n in nums2.AsSpan())
        {
            if (occurred[n] > 0)
            {
                inter[p++] = n;
                occurred[n] -= 1;
            }
        }

        return inter[..p];
    }
}

/* Followu up question:
1. Then we don't need to create occurred array, but we can compare elements of 2 arrays directly, if n1 from nums1 equals n2 from nums2,
then add it to output array and move both array pointers, if n1 is lower, move nums1 array pointer, and vice versea, until they match.
That way we are eventually getting additional memory needs on O(1).
2. In current algo if we add a total counter of occurences and start subtracting it in second loop we could have an early exit.
Other hand, in sorted arrays, we could very quickly finish going through the array and end up algo, so probably the second one, but one
would need to measure it. Additionally we can use binary search on the bigger array, therefore decreasing big O from O(M + N) to O(MlogN)
3. Then one would need to have the streaming from disk mechanism implemented.
*/