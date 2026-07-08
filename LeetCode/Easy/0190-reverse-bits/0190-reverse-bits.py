class Solution:
    def reverseBits(self, n: int) -> int:
        reversed_n = 0

        for _ in range(31):
            reversed_n |= n & 1
            reversed_n <<= 1
            n >>= 1
        
        return reversed_n