class Solution:
    # Based on combinatorics - we know we need to make m - 1 steps down and n - 1 steps right, so it's about permutation of those.
    # And permutation of set consisting 2 types of elements is P(n1, n2) = (n1 + n2)! / (n_1! * n_2!)
    def uniquePaths(self, m: int, n: int) -> int:
        return int(math.factorial(m - 1 + n - 1) / (math.factorial(m - 1) * math.factorial(n - 1))) 