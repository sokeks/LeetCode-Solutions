public class Solution {
    private int _rowsCount;
    private int _columnsCount;

    public int NearestExit(char[][] maze, int[] entrance) {
        _rowsCount = maze.Length;
        _columnsCount = maze[0].Length;

        var nextCells = new Queue<(int x, int y, int stepsMade)>();
        nextCells.Enqueue((entrance[0], entrance[1], 0));

        var cellsVisited = new bool[_rowsCount * _columnsCount];
        cellsVisited[CalculateVisitedIndex(entrance)] = true;

        ReadOnlySpan<(int, int)> offsets = [(- 1, 0), (1, 0), (0, -1), (0, 1)];
        while (nextCells.Count > 0)
        {
            var (x, y, stepsMade) = nextCells.Dequeue();

            foreach (var (horizontal, vertical) in offsets)
            {
                var newX = x + horizontal;
                var newY = y + vertical;
                if (IsAllowed(newX, newY, maze, cellsVisited, out int cellsVisitedIndex))
                {
                    if (IsOnEdge(newX, newY, maze)) return stepsMade + 1;
                    nextCells.Enqueue((newX, newY, stepsMade + 1));
                    cellsVisited[cellsVisitedIndex] = true;
                }                
            }
        }

        return -1;
    }

    private bool IsAllowed(int x, int y, char[][] maze, bool[] cellsVisited, out int cellsVisitedIndex)
    {
        if (x >= 0 && x < _rowsCount && y >= 0 && y < _columnsCount && maze[x][y] == '.')
        {
            cellsVisitedIndex = CalculateVisitedIndex(x, y);
            return !cellsVisited[cellsVisitedIndex];
        }
        cellsVisitedIndex = -1;
        return false;
     } 

    private bool IsOnEdge(int x, int y, char[][] maze)
        => x == 0 || x == _rowsCount - 1 || y == 0 || y == _columnsCount - 1;

    private int CalculateVisitedIndex(int[] coordinates)
        => CalculateVisitedIndex(coordinates[0], coordinates[1]);

    private int CalculateVisitedIndex(int x, int y)
            => x * _columnsCount + y;
}