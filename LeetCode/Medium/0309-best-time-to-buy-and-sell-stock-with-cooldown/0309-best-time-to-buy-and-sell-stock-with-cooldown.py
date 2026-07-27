class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        without_stock = 0
        with_stock = -prices[0]
        cooldown = 0
        for price in islice(prices, 1, None):
            without_stock, with_stock, cooldown = max(without_stock, cooldown), max(with_stock, without_stock - price), (with_stock + price)
        
        return max(without_stock, cooldown)
        