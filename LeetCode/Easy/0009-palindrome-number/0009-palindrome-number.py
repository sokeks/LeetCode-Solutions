class Solution:
    def isPalindrome(self, x: int) -> bool:
        def calcualte_length_and_reversed(x: int) -> Tuple[length: int, x_reversed: int]:
            x_reversed = 0
            copy = x
            length = 0

            while copy > 0:
                x_reversed = x_reversed * 10 + copy % 10
                copy //= 10
                length += 1

            return (length, x_reversed)

        if x < 0: return False
        
        (length, x_reversed) = calcualte_length_and_reversed(x)

        for _ in range(length // 2):
            if x % 10 != x_reversed % 10: return False
            x //= 10
            x_reversed //= 10

        return True