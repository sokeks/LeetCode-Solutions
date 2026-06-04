public class Solution {
    public int NearestExit(char[][] maze, int[] entrance) {
        var mazeW = new MazeWrapper(maze);
        var cellsMemory = new CellsMemory(maze);

        var nextCells = new Queue<(int x, int y, int stepsMade)>();
        nextCells.Enqueue((entrance[0], entrance[1], 0));

        cellsMemory.MarkAsVisited(entrance);

        ReadOnlySpan<(int, int)> offsets = [(- 1, 0), (1, 0), (0, -1), (0, 1)];
        while (nextCells.Count > 0)
        {
            var (x, y, stepsMade) = nextCells.Dequeue();

            foreach (var (horizontal, vertical) in offsets)
            {
                var newX = x + horizontal;
                var newY = y + vertical;
                if (mazeW.IsStepAllowed(newX, newY) && !cellsMemory.IsVisitedAndMarkAs(newX, newY))
                {
                    if (mazeW.IsOnEdge(newX, newY)) return stepsMade + 1;
                    nextCells.Enqueue((newX, newY, stepsMade + 1));
                }                
            }
        }

        return -1;
    }

    public ref struct MazeWrapper
    {
        private readonly char[][] _maze;
        private readonly int _rowsCount;
        private readonly int _columnsCount;

        public MazeWrapper(char[][] maze)
        {
            _maze = maze;
            _rowsCount = maze.Length;
            _columnsCount = maze[0].Length;
        }

        public bool IsStepAllowed(int x, int y)
            => x >= 0 && x < _rowsCount && y >= 0 && y < _columnsCount && _maze[x][y] == '.';

        public bool IsOnEdge(int x, int y)
            => x == 0 || x == _rowsCount - 1 || y == 0 || y == _columnsCount - 1;
    }

    public ref struct CellsMemory
    {
        private readonly bool[] _cellsVisited;
        private readonly int _columnsCount;

        public CellsMemory(char[][] maze)
        {
            _columnsCount = maze[0].Length;
            _cellsVisited = new bool[maze.Length * _columnsCount];
        }

        public void MarkAsVisited(int[] coordinates)
            => _cellsVisited[CalculateVisitedIndex(coordinates[0], coordinates[1])] = true;

        public bool IsVisitedAndMarkAs(int x, int y)
        {
            var idx = CalculateVisitedIndex(x, y);
            var isVisited = _cellsVisited[idx];
            if (!isVisited) _cellsVisited[idx] = true;
            return isVisited;
        }

        public bool IsVisited(int x, int y)
            => _cellsVisited[CalculateVisitedIndex(x, y)];

        private int CalculateVisitedIndex(int x, int y)
            => x * _columnsCount + y;
    }
}