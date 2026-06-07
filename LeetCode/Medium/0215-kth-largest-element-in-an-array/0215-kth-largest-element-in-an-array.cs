public class Solution {
    // --- 3 way QuickSelect solution (the fastest) ---
    // public int FindKthLargest(int[] nums, int k) {
    //     Span<int> copy = nums.Length <= 1024 ? stackalloc int[nums.Length] : new int[nums.Length];
    //     nums.AsSpan().CopyTo(copy);

    //     var kIdx = copy.Length - k;

    //     return QuickSelect(copy, kIdx);

    //     static int QuickSelect(Span<int> nums, int kIdx)
    //     {
    //         var left = 0;
    //         var right = nums.Length;

    //         while (left < right)
    //         {
    //             var (pivotStartIdx, pivotEndIdx) = Partition(nums, left, right);

    //             if (kIdx >= pivotStartIdx && kIdx <= pivotEndIdx)
    //             {
    //                 return nums[kIdx];
    //             }
    //             else if (kIdx > pivotEndIdx)
    //             {
    //                 left = pivotEndIdx + 1;
    //             }
    //             else // if (kIdx < pivotStartIdx)
    //             {
    //                 right = pivotStartIdx;
    //             }
    //         }

    //         throw new System.Diagnostics.UnreachableException("Flaw in the Algorithm");
    //                     // --- original Partition function for 3 ways QuickSelect (Dutch Flag algoirthm) ---
    //         static (int pivotStartIdx, int pivotEndIdx) Partition(Span<int> nums, int left, int right)
    //         {
    //             var pivotIdx = Random.Shared.Next(left, right);
    //             var pivot = nums[pivotIdx];

    //             var lessThanIdx = left;
    //             var i = left;
    //             var greaterThanIdx = right - 1;

    //             while (i <= greaterThanIdx)
    //             {
    //                 if (nums[i] < pivot)
    //                 {
    //                     (nums[i], nums[lessThanIdx]) = (nums[lessThanIdx], nums[i]);
    //                     lessThanIdx++;
    //                     i++;
    //                 }
    //                 else if (nums[i] > pivot)
    //                 {
    //                     (nums[i], nums[greaterThanIdx]) = (nums[greaterThanIdx], nums[i]);
    //                     greaterThanIdx--;
    //                 }
    //                 else // nums[i] == pivot
    //                 {
    //                     i++;
    //                 }
    //             }

    //             return (lessThanIdx, greaterThanIdx);
    //         }
    //         // --- adjusted Partition function from 3 ways QuickSelect for simple QuickSelect ---
    //         // static (int pivotStartIdx, int pivotEndIdx) Partition(Span<int> nums, int left, int right)
    //         // {
    //         //     right = right - 1;  // moving from exclusive range to inclusive
    //         //     var pivot = nums[right];
    //         //     var storeIdx = left;
    //         //     for (var i = left; i < right; i++)
    //         //     {
    //         //         if (nums[i] < pivot)
    //         //         {
    //         //             (nums[i], nums[storeIdx]) = (nums[storeIdx], nums[i]);
    //         //             storeIdx++;
    //         //         }
    //         //     }
    //         //     (nums[storeIdx], nums[right]) = (nums[right], nums[storeIdx]);

    //         //     return (storeIdx, storeIdx);

    //         // }
    //     }
    // }

    // --- PriorityminHeap (minHeap) solution - not as fast as with 3way QuickSelect ---
    public int FindKthLargest(int[] nums, int k) {
        var minHeap = new PriorityQueue<int, int>(k);
        
        foreach (var n in nums.AsSpan()[..k]) minHeap.Enqueue(n, n);

        foreach (var n in nums.AsSpan()[k..])
        {
            if (minHeap.Peek() < n) minHeap.DequeueEnqueue(n, n);
        }

        return minHeap.Peek();
    }
}