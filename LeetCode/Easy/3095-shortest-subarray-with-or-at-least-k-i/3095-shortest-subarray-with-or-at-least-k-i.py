class Solution:
    # with the original constraints, it's ok to do it brute force. I do this task for constraints much bigger
    def minimumSubarrayLength(self, nums: List[int], k: int) -> int:
        if k == 0: return 1

        left = 0
        right = 0
        bit_set_count = [0 for _ in range(32)]
        running_or = 0
        min_length = math.inf

        while right < len(nums):
            while right < len(nums) and running_or < k:
                num = nums[right]
                right += 1
                running_or |= num
                
                pos = 0
                while num:
                    bit_status = num & 1
                    num >>= 1
                    bit_set_count[pos] += bit_status
                    pos += 1
            

            while left < right and running_or >= k:
                min_length = min(min_length, right - left)
                num = nums[left]
                left += 1

                pos = 0
                while num:
                    bit_status = num & 1
                    num >>= 1
                    bit_set_count[pos] -= bit_status
                    if bit_status and not bit_set_count[pos]:
                        running_or &= ~(1 << pos)
                    pos += 1
        
        return min_length if min_length != math.inf else -1
                