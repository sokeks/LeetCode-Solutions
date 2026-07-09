class Solution:
    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        num_2_position = {}
        for i, n in enumerate(nums):
            if n in num_2_position and (i - num_2_position[n]) <= k:
                return True
            num_2_position[n] = i

        return False