class Solution:
    def lengthOfLIS(self, nums: List[int]) -> int:
        dp = [0] * len(nums)

        for i, n in enumerate(nums):
            max_subsequence_len = 0
            for j, m in enumerate(islice(nums, 0, i)):
                if n > m and dp[j] > max_subsequence_len:  
                    max_subsequence_len = dp[j]
            dp[i] = 1 + max_subsequence_len

        return max(dp)
        