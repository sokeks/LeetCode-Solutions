class Solution:
    def sumOfGoodIntegers(self, n: int, k: int) -> int:
        compatible_sum = 0
        for x in range(max(1, n - k), k + n + 1):
            if n & x == 0 and abs(n - x) <= k: compatible_sum += x
        
        return compatible_sum