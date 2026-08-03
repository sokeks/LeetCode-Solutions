class Solution:
    # typical 2D DP task with rules:
    # 0. We want to know how the least deletes to do for whole 2 strings, and number of deletes for last chars of both strings equals number of deletes for one but last
    #    + if we need to delete the last ones.
    # 1. if word1[-1] == word[-1], we cut off both last chars and compare the last but ones
    # 2. if word1[-1] != word[-1], we know we need to delete somethng (so +1) and we ask what's the minimum of 2 paths - if we cut off word1's last char, or word2's.
    def minDistance(self, word1: str, word2: str) -> int:
        @cache
        def min_distance_rec(i: int, j: int) -> int:
            if i == 0:
                return j
            if j == 0:
                return i
            
            if word1[i - 1] == word2[j - 1]:
                return min_distance_rec(i - 1, j - 1)
            else:
                return 1 + min(min_distance_rec(i, j - 1), min_distance_rec(i - 1, j))
        
        return min_distance_rec(len(word1), len(word2))
