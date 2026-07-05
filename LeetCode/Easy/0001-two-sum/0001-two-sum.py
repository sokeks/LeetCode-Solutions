class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        occurred = {}
        for i in range(len(nums)):
            if nums[i] in occurred:
                return [occurred[nums[i]], i]
            else:
                occurred[target - nums[i]] = i
        
        return []