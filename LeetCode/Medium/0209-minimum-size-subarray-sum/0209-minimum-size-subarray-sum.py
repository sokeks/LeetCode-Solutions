class Solution:    
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        # O(log N) solution from followup
        # 0-th index -> 0 elements dropped, 1-st index -> 1 element dropped, 2-nd index -> 2 elements dropped...
        prefixes = [0]
        running_sum = 0
        min_length = float("inf")

        for idx, num in enumerate(nums):
            running_sum += num
            # running_sum - prefix >= target -> prefix <= running_sum - target
            searched_prefix = running_sum - target

            prefix_idx = bisect.bisect_right(prefixes, searched_prefix) - 1
            if prefix_idx != -1:
                # length = summed_elements_count - dropped_elements_count -> (idx + 1) - prefix_idx
                min_length = min(min_length, (idx + 1) - prefix_idx)
            
            prefixes.append(running_sum)
            
        return min_length if min_length != float("inf") else 0
        
        
        # O(n) solution without followup
        left = 0
        running_sum = 0
        min_length = float("inf")

        for right, num in enumerate(nums):            
            running_sum += num

            while running_sum >= target:
                min_length = min(min_length, right - left + 1)
                running_sum -= nums[left]
                left += 1
            
        return min_length if min_length != float("inf") else 0