class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        lowest = prices[0]
        max_profit = 0

        for price in itertools.islice(prices, 1, None):
            profit = price - lowest
            if profit > max_profit: max_profit = profit
            elif price < lowest: lowest = price

        return max_profit