class Solution:
    # Based on iteraion - less efficient comparing to the combinatorics below
    def uniquePaths(self, m: int, n: int) -> int:
        leading_path_combinations_count = [0] * n
        leading_path_combinations_count[0] = 1
        for i in range(m):
            for j in range(1, n):
                leading_path_combinations_count[j] = leading_path_combinations_count[j] + leading_path_combinations_count[j - 1]
        return leading_path_combinations_count[n - 1]


    # Based on combinatorics - we know we need to make m - 1 steps down and n - 1 steps right, so it's about permutation of those.
    # And permutation of set consisting 2 types of elements is P(n1, n2) = (n1 + n2)! / (n_1! * n_2!)
    # def uniquePaths(self, m: int, n: int) -> int:
    #     return int(math.factorial(m - 1 + n - 1) / (math.factorial(m - 1) * math.factorial(n - 1))) 