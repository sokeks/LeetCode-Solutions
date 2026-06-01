public class Solution {
    public int MinReorder(int n, int[][] connections) {
        var adjacency = new Dictionary<int, List<(int neighbour, bool isInbound)>>();

        foreach (var connection in connections)
        {
            AddNeighbours(connection, adjacency);
        }

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
        static void AddNeighbours(int[] connection, Dictionary<int, List<(int neighbour, bool isInbound)>> adjacency)
        {
            AddNeighbour(connection[0], connection[1], false, adjacency);
            AddNeighbour(connection[1], connection[0], true, adjacency);
        }

        static void AddNeighbour(int first, int second, bool isInbound, Dictionary<int, List<(int neighbour, bool isInbound)>> adjacency)
        {
            if (adjacency.TryGetValue(first, out List<(int neighbour, bool isInbound)> list))
            {
                list.Add((second, isInbound));
            } 
            else
            {
                adjacency[first] = new List<(int neighbour, bool isInbound)>() {(second, isInbound)};
            }
        }

    }
}