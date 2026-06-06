public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        Span<int> copy = nums.Length <= 1024 ? stackalloc int[nums.Length] : new int[nums.Length];
        nums.AsSpan().CopyTo(copy);

        var kIdx = copy.Length - k;

        Console.WriteLine($"Begin: {string.Join(',', nums.ToArray())}");

        return ThreeWayQuickSelect(copy, kIdx);

        static int ThreeWayQuickSelect(Span<int> nums, int kIdx)
        {
            var left = 0;
            var right = nums.Length;

            while (left <= right)
            {
                var (lessThanIdx, greaterThanIdx) = Partition(nums, left, right);
                // Console.WriteLine($"{lessThanIdx} | {greaterThanIdx} | {left} | {right} | {string.Join(',', nums.ToArray())}");

                if (kIdx >= lessThanIdx && kIdx <= greaterThanIdx)
                {
                    return nums[kIdx];
                }
                else if (kIdx > greaterThanIdx)
                {
                    left = greaterThanIdx;
                }
                else // if (kIdx < lessThanIdx)
                {
                    right = lessThanIdx;
                }
            }

            throw new System.Diagnostics.UnreachableException("Flaw in the Algorithm");
            static (int lessThanIdx, int greaterThanIdx) Partition(Span<int> nums, int left, int right)
            {
                var pivotIdx = Random.Shared.Next(left, right);
                // Console.WriteLine(pivotIdx);
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