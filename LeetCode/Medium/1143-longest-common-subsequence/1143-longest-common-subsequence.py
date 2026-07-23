class Solution:
    # iterative approach with compressed memory approach
    #
    # lcs table (compressed then to 1 row)
    # |   | 0 | t | e | x | t | 2 |
    # | t |
    # | e |
    # | x |
    # | t |
    # | 1 |
    # 
    # def longestCommonSubsequence(self, text1: str, text2: str) -> int:
    #     lcs = [0] * (len(text2) + 1)

    #     for r, t1 in enumerate(text1):
    #         prev_diagonal = lcs[0]
    #         for c, t2 in enumerate(text2):
    #             prev_diagonal, lcs[c + 1] = lcs[c + 1], (prev_diagonal + 1) if t1 == t2 else max(lcs[c], lcs[c + 1])
            
    #     return lcs[-1]
    
    # recursive approach
    def longestCommonSubsequence(self, text1: str, text2: str) -> int:
        @cache
        def lcsRec(r: int, c: int) -> int:
            if r < 0 or c < 0:
                return 0
            
            if text1[r] == text2[c]:
                return lcsRec(r - 1, c - 1) + 1
            else:
                return max(lcsRec(r, c - 1), lcsRec(r - 1, c))
        
        return lcsRec(len(text1) - 1, len(text2) - 1)