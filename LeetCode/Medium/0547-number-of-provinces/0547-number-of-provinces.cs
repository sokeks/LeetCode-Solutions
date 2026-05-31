public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        var provincesCount = 0;

        var townsToVisit = new Stack<int>(isConnected.Length);
        Span<bool> visitedTowns = isConnected.Length <= 1024 ? stackalloc bool[isConnected.Length] : new bool[isConnected.Length];

        for (var i = 0; i < isConnected.Length ; i++)
        {
            if (visitedTowns[i]) continue;

            visitedTowns[i] = true;
            townsToVisit.Push(i);
            provincesCount++;

            while (townsToVisit.Count > 0)
            {
                var visitingTown = townsToVisit.Pop();
                for (var j = 0; j < isConnected[visitingTown].Length; j++)
                {
                    if (isConnected[visitingTown][j] == 1 && !visitedTowns[j])
                    {
                        visitedTowns[j] = true;
                        townsToVisit.Push(j);
                    }
                }
            }
        }
        
        return provincesCount;
    }
}