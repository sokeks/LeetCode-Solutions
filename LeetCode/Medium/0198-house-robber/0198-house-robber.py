class Solution:
    def rob(self, nums: List[int]) -> int:
        prev2 = 0
        prev1 = 0

        for current_house in nums:
            prev2, prev1 = prev1, max(prev1, prev2 + current_house)
        
        return prev1
