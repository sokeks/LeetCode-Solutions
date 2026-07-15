class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        # proposed version, but failing with Timi Limit Exceeded
        available = set(nums)
        max_length = 0

        for n in available:
            if (n - 1) in available:
                continue
            
            current = n
            while current in available:
                current += 1
            
            max_length = max(max_length, current - n)

        return max_length

        # my initial version
        available = set(nums)
        visited = set()
        max_length = 0

        for n in nums:
            if n in visited:
                continue
            visited.add(n)
            
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