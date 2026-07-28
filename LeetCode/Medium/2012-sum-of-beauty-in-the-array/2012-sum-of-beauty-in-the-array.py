class Solution:
    def sumOfBeauties(self, nums: List[int]) -> int:
        mins: list[int] = [0] * len(nums)
        mins[-1] = nums[-1]
        for i in range(len(nums) - 2, 1, -1):
            if nums[i] >= mins[i + 1]:
                mins[i] = mins[i + 1]
            else:
                mins[i] = nums[i]

        beauty_sum = 0
        max_seen = nums[0]
        for i in range(1, len(nums) - 1):
            if max_seen < nums[i] < mins[i + 1]:
                beauty_sum += 2
            elif nums[i - 1] < nums[i] < nums[i + 1]:
                beauty_sum += 1

            if nums[i] > max_seen:
                max_seen = nums[i]
        
        return beauty_sum
        