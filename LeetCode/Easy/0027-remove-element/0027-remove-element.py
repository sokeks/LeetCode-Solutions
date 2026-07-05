class Solution:
    def removeElement(self, nums: List[int], val: int) -> int:
        garbage_ptr = len(nums) - 1
        read_ptr = 0

        while read_ptr <= garbage_ptr:
            if nums[read_ptr] == val:
                nums[read_ptr], nums[garbage_ptr] = nums[garbage_ptr], nums[read_ptr]
                garbage_ptr -= 1
            else:
                read_ptr += 1

                        
        return read_ptr

        