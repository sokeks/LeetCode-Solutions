class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        without_stock = 0
        with_stock = -prices[0]

        for price in islice(prices, 1, None):
            without_stock, with_stock = max(without_stock, with_stock + price), max(without_stock - price, with_stock)

        return without_stock
        