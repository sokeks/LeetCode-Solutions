class Solution:
    def jump(self, nums: List[int]) -> int:

        jumps_count = 0
        current_reach = 0
        next_reach = 0
        for i in range(len(nums) - 1):
            next_reach = max(next_reach, nums[i] + i)
            if next_reach >= len(nums) - 1:
                return jumps_count + 1

            if current_reach == i:
                jumps_count += 1
                current_reach = next_reach
            


        return jumps_count