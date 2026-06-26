class Solution:
    def rob(self, nums: List[int]) -> int:
        prev2 = 0
        prev1 = 0

        for i in range(len(nums)):
            prev2, prev1 = prev1, max(prev1, prev2 + nums[i])
            # print(f"prev2={prev2}, prev1={prev1}")
        
        return prev1


                    # print(f"prev3={prev3}, prev2={prev2}, prev1={prev1}")
