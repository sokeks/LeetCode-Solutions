public class Solution {
    public long MaxScore(int[] nums1, int[] nums2, int k) {
        var indices = nums1.Length <= 1024 ? stackalloc int[nums1.Length] : new int[nums1.Length];
        SortIndicesByArrayValues(indices, nums2);

        var sum = 0L;
        var topValues = new PriorityQueue<int, int>(k - 1);
        foreach (var i in indices[..(k - 1)])
        {
            sum += nums1[i];
            topValues.Enqueue(nums1[i], nums1[i]);
        }

        var maxScore = 0L;
        foreach (var i in indices[(k - 1)..])
        {
            var score = (sum + nums1[i]) * nums2[i];
            if (score > maxScore) maxScore = score;

            if (topValues.Count > 0 && nums1[i] > topValues.Peek())
            {
                var previous = topValues.DequeueEnqueue(nums1[i], nums1[i]);
                sum = sum - previous + nums1[i];
            }            
        }

        return maxScore;
        static void SortIndicesByArrayValues(Span<int> indices, int[] values)
        {
            for (var i = 0; i < indices.Length; i++) indices[i] = i;

            indices.Sort(new IndexComparer(values));
        }
    }

    public readonly struct IndexComparer : IComparer<int>
    {
        private readonly int[] _values;
        public IndexComparer(int[] values) => _values = values;

        public int Compare(int i1, int i2) => _values[i2].CompareTo(_values[i1]);
    }
}