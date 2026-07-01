class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        prefix_sums_heap = [0]

        largest_sum = float("-inf")
        current_prefix = 0
        for n in nums:
            current_prefix += n
            # print(f"current_prefix={current_prefix}\tprefix_sums_heap[0]={prefix_sums_heap[0]}\tlargest_sum={largest_sum}")
            largest_sum = max(current_prefix - prefix_sums_heap[0], largest_sum)
            heapq.heappush(prefix_sums_heap, current_prefix)

        return largest_sum