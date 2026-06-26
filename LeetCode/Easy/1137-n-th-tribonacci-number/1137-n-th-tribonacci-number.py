class Solution:
    def tribonacci(self, n: int) -> int:
        t_0 = 0
        t_1 = 1
        t_2 = 1
        if n == 0: return t_0
        if n == 1: return t_1
        if n == 2: return t_2

        for _ in range(n - 2):
            t_0, t_1, t_2 = t_1, t_2, t_0 + t_1 + t_2
        
        return t_2