public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var max = candies[0];
        for (var i = 1; i < candies.Length; i++)
        {
            if (candies[i] > max) max = candies[i];
        }

        var threshold = max - extraCandies;
        var results = new bool[candies.Length];
        for (var i = 0; i < candies.Length; i++)
        {
            results[i] = candies[i] >= threshold;
        }

        return results;        
    }
}