public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        Span<int> copy = nums.Length <= 1024 ? stackalloc int[nums.Length] : new int[nums.Length];
        nums.AsSpan().CopyTo(copy);

        var kIdx = copy.Length - k;

        return ThreeWayQuickSelect(copy, kIdx);

        static int ThreeWayQuickSelect(Span<int> nums, int kIdx)
        {
            var left = 0;
            var right = nums.Length;

            while (left < right)
            {
                var (pivotStartIdx, pivotEndIdx) = Partition(nums, left, right);

                if (kIdx >= pivotStartIdx && kIdx <= pivotEndIdx)
                {
                    return nums[kIdx];
                }
                else if (kIdx > pivotEndIdx)
                {
                    left = pivotEndIdx + 1;
                }
                else // if (kIdx < pivotStartIdx)
                {
                    right = pivotStartIdx;
                }
            }

            throw new System.Diagnostics.UnreachableException("Flaw in the Algorithm");
            static (int pivotStartIdx, int pivotEndIdx) Partition(Span<int> nums, int left, int right)
            {
                var pivotIdx = Random.Shared.Next(left, right);
                var pivot = nums[pivotIdx];

                var lessThanIdx = left;
                var i = left;
                var greaterThanIdx = right - 1;

                while (i <= greaterThanIdx)
                {
                    if (nums[i] < pivot)
                    {
                        (nums[i], nums[lessThanIdx]) = (nums[lessThanIdx], nums[i]);
                        lessThanIdx++;
                        i++;
                    }
                    else if (nums[i] > pivot)
                    {
                        (nums[i], nums[greaterThanIdx]) = (nums[greaterThanIdx], nums[i]);
                        greaterThanIdx--;
                    }
                    else // nums[i] == pivot
                    {
                        i++;
                    }
                }

                return (lessThanIdx, greaterThanIdx);
            }
        }
    }
}