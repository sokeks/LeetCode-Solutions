class Solution:
    def longestPalindrome(self, s: str, t: str) -> int:
        def calcualte_longest_palindrom_len_from_idx(x: str) -> list[int]:
            x_length = len(x)
            palindrome_lens = [0] * (x_length + 1)
            def expand(left: int, right: int):
                while left >= 0 and right < x_length and x[left] == x[right]:
                    palindrome_lens[left] = right - left + 1
                    left -= 1
                    right += 1
                
            for center in range(x_length):
                expand(center, center)      # odd
                expand(center, center + 1)  # even
            
            return palindrome_lens

        r = t[::-1]
        s_palindrome_lens = calcualte_longest_palindrom_len_from_idx(s)
        r_palindrome_lens = calcualte_longest_palindrom_len_from_idx(r)

        max_palindrome_len = max(max(s_palindrome_lens), max(r_palindrome_lens))

        dp = [0] * len(r)
        for i in range(len(s)):
            prev = 0
            for j in range(len(r)):
                matches = s[i] == r[j]
                prev, dp[j] = dp[j], (1 + prev if matches else 0) 

                if matches:
                    max_palindrome_len = max(
                        max_palindrome_len,
                        2 * dp[j] + max(s_palindrome_lens[i + 1], r_palindrome_lens[j + 1]),
                    )

        return max_palindrome_len
