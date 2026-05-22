public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1)
        {
            return s;
        }
        var rows = new StringBuilder[numRows];
        for (var ii = 0; ii < numRows; ++ii)
        {
            rows[ii] = new StringBuilder();
        }
        var isGoingDown = false;
        var currentRow = 0;
        for (var ii = 0; ii < s.Length; ++ii)
        {
            rows[currentRow].Append(s[ii]);

            if (currentRow == 0 || currentRow == numRows - 1)
            {
                isGoingDown = !isGoingDown; 
            }
            currentRow += isGoingDown ? 1 : -1;
        }

        var master = new StringBuilder(s.Length);
        for (var ii = 0; ii < numRows; ++ii)
        {
            master.Append(rows[ii]);
        }

        return master.ToString();
    }

}