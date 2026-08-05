class Solution:
    def increasingTriplet(self, nums: List[int]) -> bool:
        if len(nums) < 3:
            return False
        smallest = float("inf")
        medium = float("inf")

        for n in nums:
            if smallest >= n:
                smallest = n
            elif medium >= n:
                medium = n
            elif n > medium:
                return True

        return False
        