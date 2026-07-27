class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        bought_1st_stock = -prices[0]
        sold_1st_stock = 0
        bought_2nd_stock = -prices[0]
        sold_2nd_stock = sold_1st_stock
    
        for p in islice(prices, 1, None):
            bought_1st_stock, sold_1st_stock, bought_2nd_stock, sold_2nd_stock = (
                max(bought_1st_stock, -p), max(bought_1st_stock + p, sold_1st_stock), max(bought_2nd_stock, sold_1st_stock - p), max(sold_2nd_stock, bought_2nd_stock + p))
        
        return max(sold_1st_stock, sold_2nd_stock)