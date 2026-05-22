public class Solution {
    public int TitleToNumber(string columnTitle) {
        var columnNumber = 0;
        for (int i = 0; i < columnTitle.Length; i++)
        {
            columnNumber = columnNumber * 26 + ((columnTitle[i] - 'A') + 1);
        }
        
        return columnNumber;
    }
}