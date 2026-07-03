class Solution:
    def minPathSum(self, grid: List[List[int]]) -> int:
        cost_row = list(accumulate(grid[0]))

        cost_row_len = len(cost_row)
        for row in range(1, len(grid)):
            cost_row[0] += grid[row][0]
            for col in range(1, cost_row_len):
                cost_row[col] = grid[row][col] + min(cost_row[col], cost_row[col - 1])
        
        return cost_row[-1]

    # recursve version 
    def minPathSum(self, grid: List[List[int]]) -> int:
        @cache
        def min_path_sum_rec(row: int, col: int) -> int:
            if row < 0 or col < 0: return sys.maxsize
            if row == 0 and col == 0: return grid[row][col]

            return  grid[row][col] + min(min_path_sum_rec(row - 1, col), min_path_sum_rec(row, col - 1))
        
        return min_path_sum_rec(len(grid) - 1, len(grid[0]) - 1)
        