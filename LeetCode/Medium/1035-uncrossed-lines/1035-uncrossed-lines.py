class Solution:
    def maxUncrossedLines(self, nums1: List[int], nums2: List[int]) -> int:
        shorter, longer = (nums1, nums2) if nums1 <= nums2 else (nums2, nums1)
        shorter_len, longer_len = len(shorter), len(longer)

        # how many connections made till getting to this level
        dp = [[0] * (len(shorter) + 1) for _ in range(len(longer) + 1)]
        
        for i in range(1, longer_len + 1):
            # prev_diagonal = dp[i][0]
            for j in range(1, shorter_len + 1):
                if longer[i - 1] == shorter[j - 1] and dp[i - 1][j] == dp[i][j - 1] == dp[i - 1][j - 1]:
                    dp[i][j] = 1 + dp[i - 1][j]
                else:
                    dp[i][j] = dp[i - 1][j] if dp[i - 1][j] > dp[i][j - 1] else dp[i][j - 1]

        return dp[-1][-1]