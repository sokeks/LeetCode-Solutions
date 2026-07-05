class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        for idx, chars in enumerate(zip(*strs)):
            if any(c != chars[0] for c in chars):
                return strs[0][:idx]
        
        return strs[0][0:len(min(strs, key=len))]