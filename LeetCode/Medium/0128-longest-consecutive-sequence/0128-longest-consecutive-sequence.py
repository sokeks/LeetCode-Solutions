class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        available = set(nums)
        visited = set()
        max_length = 0

        for n in nums:
            if n in visited:
                continue
            
            lower = n
            while (lower - 1) in available:
                lower -= 1
                visited.add(lower)

            higher = n
            while (higher + 1) in available:
                higher += 1
                visited.add(higher) 
            
            max_length = max(max_length, higher - lower + 1)

        return max_length