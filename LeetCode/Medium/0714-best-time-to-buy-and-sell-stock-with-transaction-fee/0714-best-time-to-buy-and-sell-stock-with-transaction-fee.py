class Solution:
    def maxProfit(self, prices: List[int], fee: int) -> int:
        without_stock = 0
        with_stock = -prices[0]

        for stock_price in islice(prices, 1, None):
            without_stock, with_stock = max(without_stock, with_stock + stock_price - fee), max(with_stock, without_stock - stock_price)
        
        return without_stock