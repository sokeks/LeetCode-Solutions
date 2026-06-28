class Solution:
    def fib(self, n: int) -> int:
        fib_minus_2 = 0
        fib_minus_1 = 1

        if (n == 0): return fib_minus_2
        if (n == 1): return fib_minus_1

        for i in range (2, n + 1):
            fib_minus_2, fib_minus_1 = fib_minus_1, fib_minus_1 + fib_minus_2
        
        return fib_minus_1