class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x == 0: return True
        if x < 0 or (x >= 10 and x % 10 == 0): return False

        x_reversed = 0
        copy = x

        while x_reversed < copy:
            x_reversed = x_reversed * 10 + copy % 10
            copy //= 10

        print(copy)
        print(x_reversed)

        return x_reversed == copy or (x_reversed // 10) == copy