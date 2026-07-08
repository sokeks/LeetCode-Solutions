class Solution:
    def reverseBits(self, n: int) -> int:
        reversed_n = 0
        bits_count = 0

        while n:
            reversed_n |= n & 1
            reversed_n <<= 1
            n >>= 1
            bits_count += 1

        reversed_n <<= (31 - bits_count)
        
        return reversed_n
            

        