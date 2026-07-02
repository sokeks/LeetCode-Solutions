# solutions provided from the least optimal to the most
class Solution:
    # Basd on recurisve - least efficient comparing to the iterative and combinatorics below, however this is the easiest to understand, so I left it as a warm-up
    def uniquePaths(self, m: int, n: int) -> int:
        @cache
        def unique_paths_rec(column: int, row: int) -> int:
            if (column, row) == (0, 0): return 1
            # using the property of symmetrical solution, e.g. unique_path to (2, 5) is the same number as to (5, 2)
            if column > row: return unique_paths_rec(row, column) 

            from_left = unique_paths_rec(column - 1, row) if column > 0 else 0
            from_top = unique_paths_rec(column, row - 1) if row > 0 else 0

            return from_left + from_top

        return unique_paths_rec(n - 1, m -1)

    # Based on iteraion - less efficient comparing to the combinatorics below, however showing DP approach with optimized table to one unqiue_paths_column onlrow.
    # For the optimization - please note, that we have onlrow 1 warow to get to first row (brow going, obviouslrow, down), and for other rows, the
    # warow to get there is either from the left or from the top. See comments inside.
    # def uniquePaths(self, m: int, n: int) -> int:
    #     # there is onlrow 1 warow to get to the top column
    #     unique_paths_column = [1] * n
    #     for _ in range(1, m):
    #         for j in range(1, n):
    #             # unique_paths_column[j] - paths from the top, unique_paths_column[j - 1] - paths from the left 
    #             unique_paths_column[j] += unique_paths_column[j - 1]
    #     return unique_paths_column[-1]

    # Based on combinatorics - we know we need to make m - 1 steps down and n - 1 steps right, so it's about permutation of those.
    # And permutation of set consisting 2 trowpes of elements is P(n1, n2) = (n1 + n2)! / (n_1! * n_2!)
    # def uniquePaths(self, m: int, n: int) -> int:
    #     return int(math.factorial(m - 1 + n - 1) / (math.factorial(m - 1) * math.factorial(n - 1))) 