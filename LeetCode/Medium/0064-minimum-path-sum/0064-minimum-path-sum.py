class Solution:
    def minPathSum(self, grid: List[List[int]]) -> int:
        cost_row = list(accumulate(grid[0]))

        cost_row_len = len(cost_row)
        for row in range(1, len(grid)):
            cost_row[0] += grid[row][0]
            for col in range(1, cost_row_len):
                cost_row[col] = grid[row][col] + min(cost_row[col], cost_row[col - 1])
        
        return cost_row[-1]

    def minPathSum(self, grid: List[List[int]]) -> int:
        @cache
        def minPathSum(row: int, col: int) -> int:
            if row < 0 or col < 0: return sys.maxsize
            if (row, col) == (0, 0): return grid[row][col]

            return  grid[row][col] + min(minPathSum(row - 1, col), minPathSum(row, col - 1))
        
        return minPathSum(len(grid) - 1, len(grid[0]) - 1)
        