public class Solution {
    public int NearestExit(char[][] maze, int[] entrance) {
        var nextCells = new Queue<(int x, int y, int stepsMade)>();
        var cellsVisited = new bool[maze.Length * maze[0].Length];

        nextCells.Enqueue((entrance[0], entrance[1], 0));
        cellsVisited[getVisitedIndex(entrance[0], entrance[1], maze)] = true;
        ReadOnlySpan<(int, int)> offsets = [(- 1, 0), (1, 0), (0, -1), (0, 1)];

        while (nextCells.Count > 0)
        {
            var (x, y, stepsMade) = nextCells.Dequeue();

            foreach (var (horizontal, vertical) in offsets)
            {
                var newX = x + horizontal;
                var newY = y + vertical;
                if (isAllowed(newX, newY, maze, cellsVisited))
                {
                    if (isOnEdge(newX, newY, maze)) return stepsMade + 1;
                    nextCells.Enqueue((newX, newY, stepsMade + 1));
                    cellsVisited[getVisitedIndex(newX, newY, maze)] = true;
                }                
            }
        }

        return -1;
        static bool isAllowed(int x, int y, char[][] maze, bool[] cellsVisited)
            => x >= 0 && x < maze.Length && y >= 0 && y < maze[0].Length && maze[x][y] == '.' && !cellsVisited[getVisitedIndex(x, y, maze)];
        static bool isOnEdge(int x, int y, char[][] maze)
            => x == 0 || x == maze.Length - 1 || y == 0 || y == maze[0].Length - 1;
        static int getVisitedIndex(int x, int y, char[][] maze)
            => x * maze[0].Length + y;
    }
}