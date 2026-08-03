class Solution:
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