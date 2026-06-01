public class Solution {
    public int MinReorder(int n, int[][] connections) {
        var adjacency = new List<(int neighbour, bool isInbound)>[n];

        for (var i = 0; i < adjacency.Length; i++) adjacency[i] = new List<(int neighbour, bool isInbound)>();
        foreach (var connection in connections) AddNeighbours(connection, adjacency);

        var citiesToVisit = new Stack<(int city, int parent)>();
        citiesToVisit.Push((0, 0));

        var edgesChangedCount = 0;
        while (citiesToVisit.Count > 0)
        {
            var (city, parent) = citiesToVisit.Pop();
            var neighbours = adjacency[city];
            foreach (var (neighbour, isInbound) in neighbours)
            {
                if (neighbour == parent) continue;

                if (!isInbound) edgesChangedCount++;

                citiesToVisit.Push((neighbour, city));
            }
        }

        return edgesChangedCount;
        static void AddNeighbours(int[] connection, List<(int neighbour, bool isInbound)>[] adjacency)
        {
            adjacency[connection[0]].Add((connection[1], false));
            adjacency[connection[1]].Add((connection[0], true));
        }
    }
}