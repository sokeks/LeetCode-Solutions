class Solution:
    def sumOfBeauties(self, nums: List[int]) -> int:
        mins: list[tuple[int, int]] = [(nums[-1], 1)]
        for i in range(len(nums) - 2, 1, -1):
            if nums[i] >= mins[-1][0]:
                mins[-1] = (mins[-1][0], mins[-1][1] + 1)
            else:
                mins.append((nums[i], 1))

        beauty_sum = 0
        max_seen = nums[0]
        for i in range(1, len(nums) - 1):
            if nums[i] > max_seen and nums[i] < mins[-1][0]:
                beauty_sum += 2
            elif nums[i] > nums[i - 1] and nums[i] < nums[i + 1]:
                beauty_sum += 1
            
            if mins[-1][1] > 1:
                mins[-1] = (mins[-1][0], mins[-1][1] - 1)
            else:
                mins.pop()

            if nums[i] > max_seen:
                max_seen = nums[i]
        
        return beauty_sum
        