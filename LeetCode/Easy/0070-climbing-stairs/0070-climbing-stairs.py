class Solution:
    def climbStairs(self, n: int) -> int:
        steps_minus_2 = 1
        steps_minus_1 = 1

        if n == 1: return steps_minus_1

        for _ in range(1, n):
            steps_minus_2, steps_minus_1 = steps_minus_1, steps_minus_1 + steps_minus_2
        
        return steps_minus_1
        