class Solution:
    def summaryRanges(self, nums: List[int]) -> List[str]:
        results = []
        idx = 0
        while idx < len(nums):
            start = nums[idx]
            while idx < (len(nums) - 1) and nums[idx + 1] - nums[idx] == 1:
                idx += 1
            result = f"{start}->{nums[idx]}" if start != nums[idx] else str(start)
            results.append(result)
            idx += 1

        return results