public class Solution {
    public int NearestExit(char[][] maze, int[] entrance) {
        var nextCells = new Queue<(int x, int y, int stepsMade)>();
        var cellsVisited = new bool[maze.Length * maze[0].Length];

        nextCells.Enqueue((entrance[0], entrance[1], 0));
        cellsVisited[getVisitedIndex(entrance[0], entrance[1], maze[0].Length)] = true;

        while (nextCells.Count > 0)
        {
            var (x0, y0, stepsMade) = nextCells.Dequeue();

            var directions = new (int, int)[] { (x0 - 1, y0), (x0 + 1, y0), (x0, y0 - 1), (x0, y0 + 1) };
            foreach (var (x, y) in directions)
            {
                // for (var i = 0; i < cellsVisited.Length; i++) Console.WriteLine(i + ":" + cellsVisited[i]);
                if (isAllowed(x, y, maze, cellsVisited))
                {
                    if (isOnEdge(x, y, maze)) return stepsMade + 1;
                    nextCells.Enqueue((x, y, stepsMade + 1));
                    cellsVisited[getVisitedIndex(x, y, maze[0].Length)] = true;
                }                
            }
        }

        return -1;
        static bool isAllowed(int x, int y, char[][] maze, bool[] cellsVisited)
            => x >= 0 && x < maze.Length && y >= 0 && y < maze[0].Length && maze[x][y] == '.' && !cellsVisited[getVisitedIndex(x, y, maze[0].Length)];
        static bool isOnEdge(int x, int y, char[][] maze)
            => x == 0 || x == maze.Length - 1 || y == 0 || y == maze[0].Length - 1;
        static int getVisitedIndex(int x, int y, int length)
            => x * length + y;
    }
}