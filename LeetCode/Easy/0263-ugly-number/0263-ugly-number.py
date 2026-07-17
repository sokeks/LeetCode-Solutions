class Solution:
    def isUgly(self, n: int) -> bool:
        if n <= 0: return False
        prime_factors = (2, 3, 5)

        for prime in prime_factors:
            while n % prime == 0:
                n //= prime
        
        return n == 1