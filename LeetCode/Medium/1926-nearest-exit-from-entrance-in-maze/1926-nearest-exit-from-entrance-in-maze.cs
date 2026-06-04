public class Solution {
    public int NearestExit(char[][] maze, int[] entrance) {
        var nextCells = new Queue<(int x, int y, int stepsMade)>();
        var cellsVisited = new CellsVisited(maze);

        nextCells.Enqueue((entrance[0], entrance[1], 0));
        cellsVisited[entrance[0], entrance[1]] = true;
        ReadOnlySpan<(int, int)> offsets = [(- 1, 0), (1, 0), (0, -1), (0, 1)];

        while (nextCells.Count > 0)
        {
            var (x, y, stepsMade) = nextCells.Dequeue();

            foreach (var (horizontal, vertical) in offsets)
            {
                var newX = x + horizontal;
                var newY = y + vertical;
                if (IsAllowed(newX, newY, maze, cellsVisited))
                {
                    if (IsOnEdge(newX, newY, maze)) return stepsMade + 1;
                    nextCells.Enqueue((newX, newY, stepsMade + 1));
                    cellsVisited[newX, newY] = true;
                }                
            }
        }

        return -1;
        static bool IsAllowed(int x, int y, char[][] maze, CellsVisited cellsVisited)
            => x >= 0 && x < maze.Length && y >= 0 && y < maze[0].Length && maze[x][y] == '.' && !cellsVisited[x, y];
        static bool IsOnEdge(int x, int y, char[][] maze)
            => x == 0 || x == maze.Length - 1 || y == 0 || y == maze[0].Length - 1;
    }

    public class CellsVisited
    {
        private readonly int _columnsCount;
        private readonly bool[] _memory;

        public CellsVisited(char[][] maze)
        {
            _columnsCount = maze[0].Length;
            _memory = new bool[maze.Length * _columnsCount];
        }

        public bool this[int row, int col]
        {
            get => _memory[row * _columnsCount + col];
            set => _memory[row * _columnsCount + col] = value;
        }
    }
}