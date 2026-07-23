class Solution:
    def longestCommonSubsequence(self, text1: str, text2: str) -> int:
        lcs = [0] * (len(text2) + 1)

        for r, t1 in enumerate(text1):
            prev_diagonal = lcs[0]
            for c, t2 in enumerate(text2):
                prev_diagonal, lcs[c + 1] = lcs[c + 1], (prev_diagonal + 1) if t1 == t2 else max(lcs[c], lcs[c + 1])
            
        return lcs[-1]