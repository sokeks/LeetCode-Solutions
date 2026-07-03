class Solution:
    # def uniquePathsWithObstacles(self, obstacleGrid: List[List[int]]) -> int:
    #     def uniquePathsWithObstaclesRec(row: int, col: int):



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
            for j in range(columns_count):
                if obstacleGrid[i][j] == 1:
                    unique_paths_row[j] = 0
                else:
                    from_left = unique_paths_row[j - 1] if j > 0 else 0
                    from_top = unique_paths_row[j]
                    unique_paths_row[j] = from_left + from_top

        return unique_paths_row[-1]