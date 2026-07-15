class Solution:
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        left = 0
        running_sum = 0
        min_length = float("inf")

        for right, num in enumerate(nums):            
            running_sum += num

            while running_sum >= target:
                min_length = min(min_length, right - left + 1)
                running_sum -= nums[left]
                left += 1
            
        return min_length if min_length != float("inf") else 0