public class Solution {
    public int MaxProfit(int[] prices) {
        var min = prices[0];
        var currentMaxProfit = 0;
        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
            }
            else
            {
                var profit = prices[i] - min;
                if (profit > currentMaxProfit)
                {
                    currentMaxProfit = profit;
                }
            }
        }
        
        return currentMaxProfit;
    }
}