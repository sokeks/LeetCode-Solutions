class Solution:


    
    def minSubArrayLen(self, target: int, nums: List[int]) -> int:
        # O(log N) solution from followup
        prefixes = [0]
        running_sum = 0
        min_length = float("inf")


        for idx, num in enumerate(nums):
            running_sum += num
            # running_sum - prefix >= target -> prefix =< running_sum - target
            searched_prefix = running_sum - target
            prefix_idx = bisect.bisect_left(prefixes, searched_prefix)
            # print(f"prefixes={prefixes} and prefix_idx={prefix_idx}")
            if prefix_idx > 0 or prefixes[prefix_idx] == searched_prefix:
                if prefix_idx >= len(prefixes) or prefixes[prefix_idx] != searched_prefix:
                    prefix_idx -= 1
                min_length = min(min_length, idx - prefix_idx + 1)
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