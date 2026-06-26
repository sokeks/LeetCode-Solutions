class Solution:
    def rob(self, nums: List[int]) -> int:
        if len(nums) == 1: return nums[0]
        if len(nums) == 2: return max(nums[0], nums[1])
        prev2 = 0
        prev1 = 0

        for i in range(2, len(nums)):
            prev2, prev1 = prev1, max(prev1, prev2 + nums[i - 2])
            print(f"prev2={prev2}, prev1={prev1}")
        
        return max(prev1 + nums[-1], prev2 + nums[-2])


                    # print(f"prev3={prev3}, prev2={prev2}, prev1={prev1}")
