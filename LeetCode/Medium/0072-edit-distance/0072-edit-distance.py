class Solution:
    def minDistance(self, word1: str, word2: str) -> int:
        # recursive with caching the results
        # @cache
        # def min_distance_rec(i: int, j: int) -> int:
        #     if i == 0:
        #         return j
        #     if j == 0:
        #         return i
            
        #     if word1[i - 1] == word2[j - 1]:
        #         return min_distance_rec(i - 1, j - 1)
        #     else:
        #         # min (replace->diagonal, delete->left, insert->up)
        #         return 1 + min(min_distance_rec(i - 1, j - 1), min_distance_rec(i, j - 1), min_distance_rec(i - 1, j))

        # return min_distance_rec(len(word1), len(word2))

        len_1 = len(word1)
        len_2 = len(word2)
        # memory optimal, see below for extended and easier to understand dp version
        dp = list(range(len_2 + 1))
        
        for i in range(1, len_1 + 1):
            prev_diagonal, dp[0] = dp[0], i
            for j in range(1, len_2 + 1):
                if word1[i - 1] == word2[j - 1]:
                    dp[j], prev_diagonal = prev_diagonal, dp[j]
                else:
                    dp[j], prev_diagonal = 1 + min(prev_diagonal, dp[j], dp[j - 1]), dp[j]
        
        return dp[-1]
        
        # memory non-optimal
        # dp[i][j] - what's the fewest way to convert first i chars of word1 into first j chars of word2, including empty string (represented by + 1 factor)
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