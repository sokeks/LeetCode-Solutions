public class Solution {
    public int OrangesRotting(int[][] grid) {
        var cellsMemory = new CellsMemory(grid);
        var (nextOranges, totalFreshOranges) = AnalyzeOranges(grid, ref cellsMemory);
        if (totalFreshOranges == 0) return 0;
        if (nextOranges.Count == 0) return -1;

        var minimumMinutesCount = 0;
        var gridW = new GridWrapper(grid);

        ReadOnlySpan<(int x, int y)> offsets = [(-1, 0), (1, 0), (0, -1), (0, 1)];
        while (nextOranges.Count > 0)
        {
            minimumMinutesCount++;
            var nextOrangesCount = nextOranges.Count; 
            for (var i = 0; i < nextOrangesCount; i++)
            {
                var (x, y) = nextOranges.Dequeue();
                foreach (var offset in offsets)
                {
                    var move = (x + offset.x, y + offset.y);
                    if (gridW.IsMoveAvailable(move) && cellsMemory.TryMarkAsVisited(move))
                    {
                        nextOranges.Enqueue(move);
                        totalFreshOranges--;
                        if (totalFreshOranges == 0) return minimumMinutesCount;
                    }
                }
            }
        }

        return -1;
        static (Queue<(int x, int y)> nextOranges, int totalFreshOranges) AnalyzeOranges(int[][] grid, ref CellsMemory cellsMemory)
        {
            var nextOranges = new Queue<(int x, int y)>();
            var totalFreshOranges = 0;
            var columnsCount = grid[0].Length;
            for (var r = 0; r < grid.Length; r++)
            {
                for (var c = 0; c < columnsCount; c++)
                {
                    if (grid[r][c] == 1) totalFreshOranges++;
                    else if (grid[r][c] == 2)
                    {
                        nextOranges.Enqueue((r, c));
                        cellsMemory.MarkAsVisited(r, c);
                    }
                }
            }

            return (nextOranges, totalFreshOranges);
        }
    }

    public readonly ref struct GridWrapper
    {
        private readonly int[][] _grid;
        private readonly int _rowsCount;
        private readonly int _columnsCount;

        public GridWrapper(int[][] grid)
        {
            _grid = grid;
            _rowsCount = _grid.Length;
            _columnsCount = _grid[0].Length;
        }

        public bool IsMoveAvailable((int x, int y) move)
            => move.x >= 0 && move.x < _rowsCount && move.y >= 0 && move.y < _columnsCount && _grid[move.x][move.y] == 1;
    }

    public readonly ref struct CellsMemory
    {
        private readonly bool[] _cellsVisited;
        private readonly int _columnsCount;

        public CellsMemory(int[][] grid)
        {
            _columnsCount = grid[0].Length;
            _cellsVisited = new bool[grid.Length * _columnsCount];
        }

        public void MarkAsVisited(int r, int c)
        {
            _cellsVisited[CalculateIdx(r, c)] = true;
        }

        public bool TryMarkAsVisited((int x, int y) move)
        {
            var idx = CalculateIdx(move.x, move.y);
            var isVisited = _cellsVisited[idx];

            if (!isVisited)
            {
                _cellsVisited[idx] = true;
                return true;
            }
            else return false;
        }

        private int CalculateIdx(int r, int c) => r * _columnsCount + c;
    }
}