class Solution:
    def strStr(self, haystack: str, needle: str) -> int:
        # using KMP algorithm, the most effective O(N + M), but the most difficult
        h_len, n_len = len(haystack), len(needle)
        def build_lps() -> List[int]:
            lps = [0] * n_len
            length = 0
            i = 1
            while i < n_len:
                if needle[i] == needle[length]:
                    length += 1
                    lps[i] = length
                    i += 1
                else:
                    if length > 0:
                        length = lps[length - 1]
                    else:
                        lps[i] = 0
                        i += 1

            return lps

        lps = build_lps()

        i = 0
        j = 0
        while i < h_len:
            if haystack[i] == needle[j]:
                i += 1
                j += 1
                if j == n_len:
                    return i - j
            else:
                if j > 0:
                    j = lps[j - 1]
                else:
                    i += 1

        return -1

        # using pointer by pointer, looks more optimal but CPython startswith is optimized
        h_len, n_len = len(haystack), len(needle)

        for i in range(h_len - n_len + 1):
            for j in range(n_len):
                if haystack[i + j] != needle[j]:
                    break
            else:
                return i
        
        return -1

        # using built-in startswith, quite nice and fast
        h_len, n_len = len(haystack), len(needle)

        for i in range(h_len - n_len + 1):
            if haystack.startswith(needle, i):
                return i
        
        return -1


        # super simple and quick basing on built-in python function, but probably it's not what we are after
        return haystack.find(needle)
        