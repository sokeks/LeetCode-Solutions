class Solution:
    def getLongestSubsequence(self, words: List[str], groups: List[int]) -> List[str]:
        subsequence = [words[0]]
        idx = 1

        while idx < len(words):
            while idx < len(words) and groups[idx] == groups[idx - 1]: idx += 1
            
            while idx < len(words) and groups[idx] != groups[idx - 1]:
                subsequence.append(words[idx])
                idx += 1

        return subsequence

        