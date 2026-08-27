class Solution:
    def longestPalindrome(self, s: str, t: str) -> int:
        if s == t:
            return 2 * len(s)

        def calcualte_longest_palindrom_len_from_idx(x: str) -> list[int]:
            x_length = len(x)
            longest_palindrome_len_from_idx = [0] * (x_length + 1)
            for i in range(x_length):
                current_max = 1
                for j in range(i + 1, x_length):
                    left = i
                    right = j
                    while left <= right and x[left] == x[right]:
                        left += 1
                        right -= 1

                    current_max = current_max if left <= right else j - i + 1
                longest_palindrome_len_from_idx[i] = current_max

            return longest_palindrome_len_from_idx

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
            # print(dp)

        # # recurrence version with populating max_palindrome_len
        # @cache
        # def traverse_longest_common_substring_rec(s_len: int, r_len: int) -> int:
        #     nonlocal max_palindrome_len
        #     if s_len <= 0 or r_len <= 0:
        #         return 0

        #     if s[s_len - 1] == r[r_len - 1]:
        #         current_len = 1 + traverse_longest_common_substring_rec(s_len - 1, r_len - 1)
        #         max_palindrome_len = max(max_palindrome_len, 2 * current_len + max(s_palindrome_lens[s_len], r_palindrome_lens[r_len]))
        #         return current_len
        #     else:
        #         traverse_longest_common_substring_rec(s_len - 1, r_len)
        #         traverse_longest_common_substring_rec(s_len, r_len - 1)
        #         return 0

        # traverse_longest_common_substring_rec(len(s), len(r))

        return max_palindrome_len
