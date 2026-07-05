class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        write_idx = -1
        previous = nums[0]
        duplicates_count = 0
        for read_idx in range(1, len(nums)):
            if nums[read_idx] != nums[read_idx - 1]:
                if write_idx != -1:
                    nums[write_idx] = nums[read_idx]
                    write_idx += 1
            else:
                duplicates_count += 1
                if write_idx == -1:
                    write_idx = read_idx
        
        return len(nums) - duplicates_count

