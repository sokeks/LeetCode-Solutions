class Solution:
    def maxProfit(self, k: int, prices: List[int]) -> int:
        def max_profit_of_limited_options():
            bought_stocks = [-prices[0]] * k
            sold_stocks = [0] * (k + 1)

            for p in islice(prices, 1, None):
                for i in range(k - 1, -1, -1):
                    sold_stocks[i + 1] = max(bought_stocks[i] + p, sold_stocks[i + 1])
                    bought_stocks[i] = max(sold_stocks[i] - p, bought_stocks[i])

            return max(sold_stocks)

        def max_profit_of_unlimited_options():
            without_stock = 0
            with_stock = -prices[0]

            for p in islice(prices, 1, None):
                without_stock, with_stock = max(without_stock, with_stock + p), max(with_stock, without_stock - p)
            
            return without_stock

        return max_profit_of_limited_options() if k < len(prices) // 2 else max_profit_of_unlimited_options()