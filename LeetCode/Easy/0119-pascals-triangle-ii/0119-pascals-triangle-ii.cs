public class Solution {
    private bool doIterative = false;
    public IList<int> GetRow(int rowIndex) {
        if (doIterative)
        {
            var row = new int[rowIndex + 1];
            for (var i = 0; i <= rowIndex; i++) 
            {
                row[0] = 1;
                row[i] = 1;
                for (var j = i - 1; j >= 1; j--)
                {                
                    row[j] = row[j - 1] + row[j];
                }
            }
            
            return row;
        }
        else
        {
            var row = new int[rowIndex + 1];
            row[0] = 1;
            for (var i = 1; i < rowIndex + 1; i++)
            {
                row[i] = (int)(1l * row[i - 1] * (rowIndex - i + 1) / i);
            }
            return row;
        }
    }
}