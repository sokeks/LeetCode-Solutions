class Solution:
    def rob(self, nums: List[int]) -> int:
        if len(nums) == 1: return nums[0]
        if len(nums) == 2: return max(nums[0], nums[1])
        if len(nums) == 3: return max(nums[0] + nums[2], nums[1])
        prev3 = 0
        prev2 = 0
        prev1 = nums[0]

        for i in range(3, len(nums)):
            prev3, prev2, prev1 = prev2, prev1, max(prev2 + nums[i - 2], prev3 + nums[i - 3])
            # print(f"prev3={prev3}, prev2={prev2}, prev1={prev1}")
        
        return max(prev1 + nums[-1], prev2 + nums[-2], prev3 + nums[-3])