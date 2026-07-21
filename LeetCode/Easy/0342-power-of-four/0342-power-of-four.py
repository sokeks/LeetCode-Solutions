class Solution:
    def isPowerOfFour(self, n: int) -> bool:    
        if n <= 0:
            return False
        
        # with modulo 3
        return n & (n - 1) == 0 and n % 3 == 1
        
        # with bit mask
        return n & (n - 1) == 0 and n & 0x55555555 != 0