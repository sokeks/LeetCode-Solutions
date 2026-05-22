public class Solution {
    public int EqualPairs(int[][] grid) {
        var equalPairsCount = 0;

        var rowToOccurrences = new Dictionary<int[], int>(new ArrayComparer());
        for (var row = 0; row < grid.Length; row++)
        {
            rowToOccurrences.TryGetValue(grid[row], out int occurrences);
            rowToOccurrences[grid[row]] = occurrences + 1;
        }

        for (var col = 0; col < grid.Length; col++)
        {
            var column = new int[grid.Length];
            for (var row = 0; row < grid.Length; row++)
            {
                column[row] = grid[row][col];
            }

            if (rowToOccurrences.TryGetValue(column, out int occurrences)) equalPairsCount += occurrences;
        }
        
        return equalPairsCount;
    }

    struct ArrayComparer : IEqualityComparer<int[]>
    {
        public bool Equals(int[] x, int [] y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (x == null || y == null || x.Length != y.Length) return false;

            for (var i = 0; i < x.Length; i++)
            {
                if (x[i] != y[i]) return false;
            }

            return true;
        }

        public int GetHashCode(int[] x)
        {
            if (x == null || x.Length == 0) return 0;

            var hash = new HashCode();
            foreach (var n in x)
            {
                hash.Add(n);
            }

            return hash.ToHashCode();
        }

    }
}