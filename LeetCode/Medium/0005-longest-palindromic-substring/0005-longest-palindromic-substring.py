class Solution:
    def longestPalindrome(self, s: str) -> str:
        substring_start = 0
        substring_end = 1

        for i in range(len(s)):
            j = 0
            while (i - (j + 1)) >= 0 and (i + (j + 1)) < len(s) and s[i - (j + 1)] == s[i + (j + 1)]: j += 1
            with_mid_len = 2 * j + 1

            k = 0
            while (i - k) >= 0 and (i + (k + 1)) < len(s) and s[i - k] == s[i + (k + 1)]: k += 1
            without_mid_len = 2 * k
            
            substring_len = substring_end - substring_start
            if substring_len < with_mid_len or substring_len < without_mid_len:
                substring_start, substring_end = (i - j, i + j + 1) if with_mid_len > without_mid_len else (i - (k - 1), i + k + 1)

        return s[substring_start:substring_end]