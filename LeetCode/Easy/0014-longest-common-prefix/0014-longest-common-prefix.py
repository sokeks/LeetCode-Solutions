class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        prefix_chars = []
        for chars in zip(*strs):
            if len(set(chars)) > 1:
                return "".join(prefix_chars)
            prefix_chars.append(chars[0])
        
        return "".join(prefix_chars)

        