class Solution:
    def longestPalindrome(self, s: str) -> str:
        def get_longest_palindrome(start: int, left_modifier: int):
            offset = 0
            while ((start - (offset + 1 - left_modifier)) >= 0 and (start + (offset + 1)) < len(s)
                    and s[start - (offset + 1 - left_modifier)] == s[start + (offset + 1)]): offset += 1
            
            palindrome_start = start - (offset - left_modifier)
            palindrome_end = start + offset + 1
            return palindrome_start, palindrome_end, palindrome_end - palindrome_start
        
        substring_start = 0
        substring_end = 1
        substring_len = substring_end - substring_start

        for i in range(len(s)):
            with_mid_start, with_mid_end, with_mid_len = get_longest_palindrome(i, 0)
            without_mid_start, without_mid_end, without_mid_len = get_longest_palindrome(i, 1)

            if substring_len < with_mid_len or substring_len < without_mid_len:
                substring_start, substring_end = (with_mid_start, with_mid_end) if with_mid_len > without_mid_len else (without_mid_start, without_mid_end)
                substring_len = substring_end - substring_start

            # if substring_len > len(s) - i: break

        return s[substring_start:substring_end]