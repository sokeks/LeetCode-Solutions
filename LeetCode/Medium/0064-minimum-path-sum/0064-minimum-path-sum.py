class Solution:
    def minPathSum(self, grid: List[List[int]]) -> int:
        min_path_sum_row = list(accumulate(grid[0]))

        min_path_sum_row_len = len(min_path_sum_row)
        for row in range(1, len(grid)):
            min_path_sum_row[0] += grid[row][0]
            for col in range(1, min_path_sum_row_len):
                min_path_sum_row[col] = grid[row][col] + min(min_path_sum_row[col], min_path_sum_row[col - 1])
        
        return min_path_sum_row[-1]
        