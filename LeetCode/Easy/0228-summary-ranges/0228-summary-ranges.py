class Solution:
    def summaryRanges(self, nums: List[int]) -> List[str]:
        ranges = []
        idx = 0
        n = len(nums)
        while idx < n:
            start = nums[idx]
            while idx < (n - 1) and nums[idx + 1] - nums[idx] == 1:
                idx += 1
            result = f"{start}->{nums[idx]}" if start != nums[idx] else str(start)
            ranges.append(result)
            idx += 1

        return ranges