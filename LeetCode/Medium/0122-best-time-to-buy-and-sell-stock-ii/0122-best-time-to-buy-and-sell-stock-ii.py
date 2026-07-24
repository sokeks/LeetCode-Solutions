class Solution:
    def maxProfit(self, prices: List[int]) -> int:

        running_profit = 0
        for today, tomorrow in zip(islice(prices, 0, len(prices) - 1), islice(prices, 1, None)):
            profit = tomorrow - today
            if profit > 0:
                running_profit += profit
        
        return running_profit
        
        
        # solution coming from DP - 714. Best Time to Buy and Sell Stock with Transaction Fee
        without_stock = 0
        with_stock = -prices[0]

        for price in islice(prices, 1, None):
            without_stock, with_stock = max(without_stock, with_stock + price), max(without_stock - price, with_stock)

        return without_stock
