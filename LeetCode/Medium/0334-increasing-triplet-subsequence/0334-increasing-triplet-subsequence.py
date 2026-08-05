class Solution:
    def increasingTriplet(self, nums: List[int]) -> bool:
        if len(nums) < 3:
            return False
        num_1 = float("inf")
        num_2 = float("inf")

        for n in nums:
            if num_1 >= n:
                num_1 = n
            elif num_2 >= n:
                num_2 = n
            elif n > num_2:
                return True

        return False
        