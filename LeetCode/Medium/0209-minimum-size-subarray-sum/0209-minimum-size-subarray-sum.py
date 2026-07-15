class Solution:
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        left = 0
        right = 0
        running_sum = 0
        min_length = math.inf

        while right < len(nums):
            while right < len(nums) and running_sum < target:
                running_sum += nums[right]
                right += 1
            
            while left < right and running_sum >= target:
                min_length = min(min_length, right - left)
                running_sum -= nums[left]
                left += 1
        
        return min_length if min_length != math.inf else 0
            
        