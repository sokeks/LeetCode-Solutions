class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        write_idx = 0
        zeros_count = 0
        for n in nums:
            if n != 0:
                nums[write_idx] = n
                write_idx += 1
            else:
                zeros_count += 1
        
        for i in range(1, zeros_count + 1):
            nums[-i] = 0