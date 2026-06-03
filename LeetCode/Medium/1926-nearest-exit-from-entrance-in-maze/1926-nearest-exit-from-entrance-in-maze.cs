public class Solution {
    public int NearestExit(char[][] maze, int[] entrance) {
        var nextCells = new Queue<(int x, int y, int stepsMade)>();
        var cellsVisited = new bool[maze.Length][];
        for (var i = 0; i < maze.Length; i++) cellsVisited[i] = new bool[maze[0].Length];

        AddStep(entrance[0], entrance[1], -1, nextCells, cellsVisited);

        while (nextCells.Count > 0)
        {
            var (x, y, stepsMade) = nextCells.Dequeue();
            // Console.WriteLine($"{x}, {y}");
            if (x != entrance[0] || y != entrance[1])
            {
                if (x == 0 || x == maze.Length - 1 || y == 0 || y == maze[0].Length - 1) return stepsMade;
            }


            var up = x - 1;
            if (up >= 0 && maze[up][y] == '.' && !cellsVisited[up][y]) AddStep(up, y, stepsMade, nextCells, cellsVisited);
            
            var down = x + 1;
            if (down < maze.Length && maze[down][y] == '.' && !cellsVisited[down][y]) AddStep(down, y, stepsMade, nextCells, cellsVisited);
            
            var left = y - 1;
            if (left >= 0 && maze[x][left] == '.' && !cellsVisited[x][left]) AddStep(x, left, stepsMade, nextCells, cellsVisited);
            
            var right = y + 1;
            if (right < maze[0].Length && maze[x][right] == '.' && !cellsVisited[x][right]) AddStep(x, right, stepsMade, nextCells, cellsVisited);
        }

        return -1;
        static void AddStep(int x, int y, int stepsMade, Queue<(int x, int y, int stepsMade)> nextCells, bool[][] cellsVisited)
        {
            nextCells.Enqueue((x, y, stepsMade + 1));
            cellsVisited[x][y] = true;
        }
    }
}