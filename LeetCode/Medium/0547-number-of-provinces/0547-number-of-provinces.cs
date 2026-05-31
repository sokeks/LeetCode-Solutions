public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        var provincesCount = 0;

        var townsToVisit = new Stack<int>(isConnected.Length);
        Span<bool> visitedTowns = isConnected.Length <= 1024 ? stackalloc bool[isConnected.Length] : new bool[isConnected.Length];
        var visitedTownsCount = 0;

        while (visitedTownsCount < isConnected.Length)
        {
            for (var i = 0; i < isConnected.Length; i++)
            {
                if (!visitedTowns[i])
                {
                    visitedTowns[i] = true;
                    townsToVisit.Push(i);
                    visitedTownsCount++;
                    provincesCount++;
                    break;
                }
            }

            while (townsToVisit.Count > 0)
            {
                var visitingTown = townsToVisit.Pop();
                for (var i = 0; i < isConnected[visitingTown].Length; i++)
                {
                    if (isConnected[visitingTown][i] == 1 && !visitedTowns[i])
                    {
                        visitedTowns[i] = true;
                        visitedTownsCount++;
                        townsToVisit.Push(i);
                    }
                }
            }
        }
        
        return provincesCount;
    }
}