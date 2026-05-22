public class Solution {
    public int LargestAltitude(int[] gain) {
        var currentHeight = 0;
        var maxHeight = currentHeight;

        foreach (var heightDelta in gain)
        {
            currentHeight += heightDelta;
            maxHeight = Math.Max(currentHeight, maxHeight);
        }

        return maxHeight;
    }
}