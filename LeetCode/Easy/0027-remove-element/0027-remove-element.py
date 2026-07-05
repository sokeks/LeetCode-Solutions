class Solution:
    def removeElement(self, nums: List[int], val: int) -> int:
        # solution with 2 pointers, both starting from the beginning - less memory writes, but destroys cache locality
        # which is especially harmful for big arrays
        write_ptr = 0
        for i in range(len(nums)):
            if nums[i] != val:
                nums[write_ptr] = nums[i]
                write_ptr += 1

        return write_ptr



        # solution with 2 pointers, but the second pointer starting from the end - less memory writes, but destroys cache locality
        # which is especially harmful for big arrays
        garbage_ptr = len(nums) - 1
        read_ptr = 0

        while read_ptr <= garbage_ptr:
            if nums[read_ptr] == val:
                nums[read_ptr], nums[garbage_ptr] = nums[garbage_ptr], nums[read_ptr]
                garbage_ptr -= 1
            else:
                read_ptr += 1
 
        return read_ptr