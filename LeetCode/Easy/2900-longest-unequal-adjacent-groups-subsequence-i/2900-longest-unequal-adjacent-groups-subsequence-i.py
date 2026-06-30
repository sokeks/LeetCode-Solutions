class Solution:
    def getLongestSubsequence(self, words: List[str], groups: List[int]) -> List[str]:
        subsequence = [words[0]]
        idx = 1

        for idx in range(1, len(words)):
            if groups[idx] != groups[idx - 1]:
                subsequence.append(words[idx])

        return subsequence