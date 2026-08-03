class Solution:
    def minDistance(self, word1: str, word2: str) -> int:
        # memory non-optimal
        len_1 = len(word1)
        len_2 = len(word2)
        # dp[i][j] - what's the fewest way to convert first i chars of word1 into first j chars of word2
        dp = [[0] * (len_2 + 1) for _ in range(len_1 + 1)]

        for i in range(len_2 + 1):
            dp[0][i] = i
        
        for i in range(len_1 + 1):
            dp[i][0] = i
        
        for i in range(1, len_1 + 1):
            for j in range(1, len_2 + 1):
                if word1[i - 1] == word2[j - 1]:
                    dp[i][j] = dp[i - 1][j - 1]
                else:
                    # either replace, insert, delete (each costing 1) + min(ways for replace, ways for insert, ways for delete)
                    dp[i][j] = 1 + min(dp[i - 1][j - 1], dp[i][j - 1], dp[i - 1][j])

        return dp[-1][-1]