class Solution:
    def longestPalindrome(self, s: str) -> str:
        def get_longest_palindrome(left: int, right: int):
            while left >= 0 and right < len(s) and s[left] == s[right]:
                left -= 1
                right += 1
            
            return left + 1, right, right - (left + 1)
        
        substring_start = 0
        substring_end = 0
        substring_len = 0

        for i in range(len(s)):
            with_mid_start, with_mid_end, with_mid_len = get_longest_palindrome(i, i)
            without_mid_start, without_mid_end, without_mid_len = get_longest_palindrome(i, i + 1)

            if substring_len < with_mid_len or substring_len < without_mid_len:
                substring_start, substring_end = (with_mid_start, with_mid_end) if with_mid_len > without_mid_len else (without_mid_start, without_mid_end)
                substring_len = substring_end - substring_start

            if substring_len >= (len(s) - (i + 1)) * 2: break

        return s[substring_start:substring_end]