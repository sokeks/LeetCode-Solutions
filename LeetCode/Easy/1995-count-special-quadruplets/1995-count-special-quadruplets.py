class Solution:
    def countQuadruplets(self, nums: list[int]) -> int:
        distinct_quadruplets_count = 0
    # version for O(n^2)
        sums_count = defaultdict(int)
        for c in range(2, len(nums)):
            b = c - 1
            for a in range(b):
                sums_count[nums[a] + nums[b]] += 1
            
            for d in range(c + 1, len(nums)):
                fitting_sum = nums[d] - nums[c]
                distinct_quadruplets_count += sums_count[fitting_sum]

        return distinct_quadruplets_count


        distinct_quadruplets_count = 0
    # version for O(n^4)
        for a in range(len(nums)):
            for b in range(a + 1, len(nums)):
                for c in range(b + 1, len(nums)):
                    for d in range (c + 1, len(nums)):
                        if nums[a] + nums[b] + nums[c] == nums[d]:
                            distinct_quadruplets_count += 1
        
        return distinct_quadruplets_count