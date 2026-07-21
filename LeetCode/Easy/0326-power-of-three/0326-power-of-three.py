class Solution:
    def isPowerOfThree(self, n: int) -> bool:
        if n <= 0:
            return False
        
        # optimized O(1) solution
        max_32_bits_power_of_3 = 1162261467
        return max_32_bits_power_of_3 % n == 0

        # standard algorythmic O (log_3 n)
        while n % 3 == 0:
            n //= 3
        
        return n == 1