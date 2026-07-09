class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        occurred = set()

        for n in nums:
            if n in occurred:
                return True
            
            occurred.add(n)
        
        return False