class Solution:
    def numDecodings(self, s: str) -> int:
        if s[0] == '0':
            return 0
        dp = [0] * (len(s) + 1)
        dp[0] = 1
        dp[1] = 1
        print(f"{s[0]} -> {dp[1]}")


        for i in range(1, len(s)):
            single_digit = dp[i] if s[i] > '0' else 0
            double_digit = dp[i - 1] if s[i - 1] == '1' or s[i - 1] == '2' and s[i] <= '6' else 0
            
            if single_digit == 0 and double_digit == 0:
                return 0
            
            dp[i + 1] = single_digit + double_digit
            print(f"{s[i]} -> {dp[i + 1]}")

        return dp[-1]