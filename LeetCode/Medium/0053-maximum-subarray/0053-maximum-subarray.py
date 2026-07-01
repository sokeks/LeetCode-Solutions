class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        smallest_prefix = 0
        largest_sum = float("-inf")
        current_prefix = 0
        for n in nums:
            current_prefix += n
            largest_sum = max(current_prefix - smallest_prefix, largest_sum)
            smallest_prefix = min(current_prefix, smallest_prefix)

        return largest_sum