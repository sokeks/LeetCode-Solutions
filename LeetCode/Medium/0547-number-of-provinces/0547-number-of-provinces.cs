public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        Span<int> parent = isConnected.Length <= 1024 ? stackalloc int[isConnected.Length] : new int[isConnected.Length];

        for (var i = 0; i < isConnected.Length; i++)
        {
            parent[i] = i;
        }

        for (var i = 0; i < isConnected.Length; i++)
        {
            for (var j = i + 1; j < isConnected.Length; j++)
            {
                if (isConnected[i][j] == 1) Union(i, j, parent);
            }
        }

        var provincesCount = 0;

        for (var i = 0; i < parent.Length; i++)
        {
            if (parent[i] == i) provincesCount++;
        }

        return provincesCount;
        static void Union(int i, int j, Span<int> parent)
        {
            var iParent = Find(i, parent);
            var jParent = Find(j, parent);

            parent[iParent] = jParent;
        }

        static int Find(int i, Span<int> parent)
        {
            if (parent[i] == i) return i;

            return Find(parent[i], parent);
        }
    }

    // *** my first solution ***
    // public int FindCircleNum(int[][] isConnected) {
    //     var provincesCount = 0;

    //     var townsToVisit = new Stack<int>(isConnected.Length);
    //     Span<bool> visitedTowns = isConnected.Length <= 1024 ? stackalloc bool[isConnected.Length] : new bool[isConnected.Length];

    //     for (var i = 0; i < isConnected.Length ; i++)
    //     {
    //         if (visitedTowns[i]) continue;

    //         visitedTowns[i] = true;
    //         townsToVisit.Push(i);
    //         provincesCount++;

    //         while (townsToVisit.Count > 0)
    //         {
    //             var visitingTown = townsToVisit.Pop();
    //             for (var j = 0; j < isConnected[visitingTown].Length; j++)
    //             {
    //                 if (isConnected[visitingTown][j] == 1 && !visitedTowns[j])
    //                 {
    //                     visitedTowns[j] = true;
    //                     townsToVisit.Push(j);
    //                 }
    //             }
    //         }
    //     }
        
    //     return provincesCount;
    // }
}