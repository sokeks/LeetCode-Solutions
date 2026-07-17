class Solution:
    def isUgly(self, n: int) -> bool:
        if n == 0: return False
        prime_factors = (2, 3, 5)

        for prime in prime_factors:
            while True:
                quotient, rem = divmod(n, prime)
                if rem:
                    break
                n = quotient
        
        return n == 1