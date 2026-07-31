class Solution:
    def maximumProfit(self, prices: List[int], k: int) -> int:
        def maximum_profit_limited_transactions():
            bought_stock = [-prices[0]] * k
            short_sold_stock = [prices[0]] * k
            no_stock = [0] * (k + 1)

            for p in islice(prices, 1, None):
                for i in range(1, len(bought_stock) + 1):
                    no_stock[k + 1 - i] = max(no_stock[k + 1 - i], bought_stock[k - i] + p, short_sold_stock[k - i] - p)
                    bought_stock[k - i] = max(bought_stock[k - i], no_stock[k - i] - p)
                    short_sold_stock[k - i] = max(short_sold_stock[k - i], no_stock[k - i] + p)
            
            return max(no_stock)

        def maximum_profit_unlimited_transactions():
            no_stock = 0
            bought_stock = -prices[0]
            short_sold_stock = prices[0]

            for p in islice(prices, 1, None):
                no_stock, bought_stock, short_sold_stock = (max(no_stock, bought_stock + p, short_sold_stock - p),
                    max(bought_stock, no_stock + p), max(short_sold_stock, no_stock - p))
            
            return no_stock
        
        return maximum_profit_limited_transactions() if k <= len(prices) // 2 else maximum_profit_unlimited_transactions()