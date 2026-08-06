class Solution:
    def maxUncrossedLines(self, nums1: List[int], nums2: List[int]) -> int:
        shorter, longer = (nums1, nums2) if nums1 <= nums2 else (nums2, nums1)
        shorter_len, longer_len = len(shorter), len(longer)

        # how many connections made till getting to this level
        dp = [0] * (len(shorter) + 1)
        
        for i in range(1, longer_len + 1):
            prev_diagonal = dp[0]
            for j in range(1, shorter_len + 1):
                if longer[i - 1] == shorter[j - 1] and dp[j] == dp[j - 1] == prev_diagonal:
                    prev_diagonal, dp[j] = dp[j], 1 + dp[j]
                else:
                    prev_diagonal, dp[j] = dp[j], dp[j] if dp[j] > dp[j - 1] else dp[j - 1]

        return dp[-1]