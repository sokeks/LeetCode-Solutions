public class Solution {
    public long MaxScore(int[] nums1, int[] nums2, int k) {
        var indices = nums1.Length <= 1024 ? stackalloc int[nums1.Length] : new int[nums1.Length];
        SortIndicesByArrayValues(indices, nums2);

        var sum = 0L;
        var topValues = new PriorityQueue<int, int>();
        foreach (var i in indices[..(k - 1)])
        {
            sum += nums1[i];
            topValues.Enqueue(nums1[i], nums1[i]);
        }

        long? maxScore = null;
        foreach (var i in indices[(k - 1)..])
        {
            var score = (sum + nums1[i]) * nums2[i];
            if (maxScore is null || score > maxScore) maxScore = score;

            if (topValues.Count > 0 && nums1[i] > topValues.Peek())
            {
                var previous = topValues.DequeueEnqueue(nums1[i], nums1[i]);
                sum = sum - previous + nums1[i];
            }            
        }

        return maxScore.Value;
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

        public int Compare(int i1, int i2) => -1 * _values[i1].CompareTo(_values[i2]);
    }
}