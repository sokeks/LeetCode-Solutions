class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x == 0: return True
        if x < 0 or x % 10 == 0: return False

        x_reversed = 0

        while x_reversed < x:
            x_reversed = x_reversed * 10 + x % 10
            x //= 10

        return x_reversed == x or (x_reversed // 10) == x