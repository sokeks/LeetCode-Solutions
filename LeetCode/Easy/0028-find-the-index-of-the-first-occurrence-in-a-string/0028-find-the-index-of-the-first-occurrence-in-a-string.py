class Solution:
    def strStr(self, haystack: str, needle: str) -> int:
        h_len, n_len = len(haystack), len(needle)

        for i in range(h_len - n_len + 1):
            for j in range(n_len):
                if haystack[i + j] != needle[j]:
                    break
            else:
                return i
        
        return -1

        # using built-in startswith, quite nice
        h_len, n_len = len(haystack), len(needle)

        for i in range(h_len - n_len + 1):
            if haystack.startswith(needle, i):
                return i
        
        return -1


        # super simple and quick basing on built-in python function, but probably it's not what we are after
        return haystack.find(needle)
        