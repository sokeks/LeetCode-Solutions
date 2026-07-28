class Solution:
    def maximumDifference(self, nums: List[int]) -> int:
        running_max_difference = float("-inf")
        running_global_min = float("inf")

        for n in nums:
            if n < running_global_min:
                running_global_min = n
            else:
                difference = n - running_global_min
                if difference > 0 and difference > running_max_difference:
                    running_max_difference = n - running_global_min
        
        return running_max_difference if running_max_difference != float("-inf") else -1

        