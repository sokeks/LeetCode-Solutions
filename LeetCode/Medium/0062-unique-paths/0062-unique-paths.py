class Solution:
    # Based on iteraion - less efficient comparing to the combinatorics below, however showing DP approach with optimized table to one unqiue_paths_row only.
    # For the optimization - please note, that we have only 1 way to get to first column (by going, obviously, down), and for other columns, the
    # way to get there is either from the left or from the top. See comments inside.
    def uniquePaths(self, m: int, n: int) -> int:
        # there is only 1 way to get to the top row
        unique_paths_row = [1] * n
        for _ in range(1, m):
            for j in range(1, n):
                # unique_paths_row[j] - paths from the top, unique_paths_row[j - 1] - paths from the left 
                unique_paths_row[j] += unique_paths_row[j - 1]
        return unique_paths_row[-1]


    # Based on combinatorics - we know we need to make m - 1 steps down and n - 1 steps right, so it's about permutation of those.
    # And permutation of set consisting 2 types of elements is P(n1, n2) = (n1 + n2)! / (n_1! * n_2!)
    # def uniquePaths(self, m: int, n: int) -> int:
    #     return int(math.factorial(m - 1 + n - 1) / (math.factorial(m - 1) * math.factorial(n - 1))) 