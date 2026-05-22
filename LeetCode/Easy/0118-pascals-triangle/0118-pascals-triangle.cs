public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var rows = new int[numRows][];

        for (var i = 0; i < numRows; i++)
        {
            var row = new int[i + 1];
            row[0] = 1;
            row[i] = 1;
            for (var j = 1; j < i; j++)
            {
                row[j] = rows[i - 1][j - 1] + rows[i - 1][j];
            }
            rows[i] = row;
        }

        return rows;
    }
}