class NumArray:

    def __init__(self, nums: List[int]):
        self.prefixes = [0]
        
        running_sum = 0
        for n in nums:
            running_sum += n
            self.prefixes.append(running_sum)

    def sumRange(self, left: int, right: int) -> int:
        return self.prefixes[right + 1] - self.prefixes[left]


# Your NumArray object will be instantiated and called as such:
# obj = NumArray(nums)
# param_1 = obj.sumRange(left,right)