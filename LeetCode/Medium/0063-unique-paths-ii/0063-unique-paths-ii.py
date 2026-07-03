class Solution:
    # iterative version, optimal comparing to the recursive (see below)
    def uniquePathsWithObstacles(self, obstacleGrid: List[List[int]]) -> int:
        def get_first_row_unique_paths(row):
            was_obstacle = False
            for square in row:
                if square == 1 or was_obstacle:
                    was_obstacle = True
                    yield 0
                else: yield 1
        
        unique_paths_row = list(get_first_row_unique_paths(obstacleGrid[0]))

        columns_count = len(obstacleGrid[0])
        for i in range(1, len(obstacleGrid)):
            if obstacleGrid[i][0] == 1:
                unique_paths_row[0] = 0
            for j in range(1, columns_count):
                if obstacleGrid[i][j] == 1:
                    unique_paths_row[j] = 0
                else:
                    unique_paths_row[j] += unique_paths_row[j - 1]

        return unique_paths_row[-1]

    # Recursive version, less efficient due to cache locality misses related to @cache allocating (row, col) and version in different places of a heap.
    # Additionally, in bigger grids we may hit stack overflow.
    # def uniquePathsWithObstacles(self, obstacleGrid: List[List[int]]) -> int:
    #     @cache
    #     def uniquePathsWithObstaclesRec(row: int, col: int) -> int:
    #         if row < 0 or col < 0: return 0
    #         if obstacleGrid[row][col] == 1: return 0
    #         if (row, col) == (0, 0): return 1

    #         return uniquePathsWithObstaclesRec(row - 1, col) + uniquePathsWithObstaclesRec(row, col - 1)

    #     return  uniquePathsWithObstaclesRec(len(obstacleGrid) - 1, len(obstacleGrid[0]) - 1)