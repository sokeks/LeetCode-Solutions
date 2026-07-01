class Solution:
    def canJump(self, nums: List[int]) -> bool:
        next_reach = 0
        for i in range(len(nums)):
            next_reach = max(next_reach, nums[i] + i)
            if next_reach >= len(nums) - 1:
                return True
            
            if next_reach == i:
                return False
        
        return False
        