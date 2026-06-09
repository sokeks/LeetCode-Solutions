public class Solution {
    public long MaxScore(int[] nums1, int[] nums2, int k) {
        if (k == 1)
        {
            return CalculateMaxProduct(nums1, nums2);
        }
        var combined = nums1.Length <= 1024 ? stackalloc (int num1, int num2)[nums1.Length] : new (int num1, int num2)[nums1.Length];
        PopulateAndSortBySecond(combined, nums1, nums2);

        var sum = 0L;
        var topValues = new PriorityQueue<int, int>(k - 1);
        foreach (var c in combined[..(k - 1)])
        {
            sum += c.num1;
            topValues.Enqueue(c.num1, c.num1);
        }

        var maxScore = 0L;
        foreach (var c in combined[(k - 1)..])
        {
            var score = (sum + c.num1) * c.num2;
            if (score > maxScore) maxScore = score;

            if (c.num1 > topValues.Peek())
            {
                var previous = topValues.DequeueEnqueue(c.num1, c.num1);
                sum = sum - previous + c.num1;
            }            
        }

        return maxScore;
        static void PopulateAndSortBySecond(Span<(int num1, int num2)> combined, int[] nums1, int[] nums2)
        {
            for (var i = 0; i < combined.Length; i++) combined[i] = (nums1[i], nums2[i]);

            combined.Sort(new CombinedComparer());
        }

        static long CalculateMaxProduct(int[] nums1, int[] nums2)
        {
            long maxScore = 0;
            for (var i = 0; i < nums1.Length; i++)
            {
                maxScore = Math.Max((long)nums1[i] * nums2[i], maxScore);
            }

            return maxScore;
        }
    }

    public readonly struct CombinedComparer : IComparer<(int num1, int num2)>
    {
        public int Compare((int num1, int num2) c1, (int num1, int num2) c2) => c2.num2.CompareTo(c1.num2);
    }
}