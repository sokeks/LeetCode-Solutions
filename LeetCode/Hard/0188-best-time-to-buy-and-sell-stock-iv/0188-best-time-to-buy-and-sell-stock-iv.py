class Solution:
    def maxProfit(self, k: int, prices: List[int]) -> int:
        def max_profit_of_limited_options():
            bought_stocks = [-prices[0]] * k
            sold_stocks = [0] * (k + 1)

            for p in islice(prices, 1, None):
                for i in range(k - 1, -1, -1):
                    profit_after_sell = bought_stocks[i] + p
                    if profit_after_sell > sold_stocks[i + 1]:
                        sold_stocks[i + 1] = profit_after_sell
                    
                    profit_after_buy = sold_stocks[i] - p
                    if profit_after_buy > bought_stocks[i]:
                        bought_stocks[i] = profit_after_buy




                    # sold_stocks[i + 1] = max(bought_stocks[i] + p, sold_stocks[i + 1])
                    # bought_stocks[i] = max(sold_stocks[i] - p, bought_stocks[i])

            return max(sold_stocks)

        def max_profit_of_unlimited_options():
            running_profit = 0

            for i in range(1, len(prices)):
                if prices[i] > prices[i - 1]:
                    running_profit += (prices[i] - prices[i - 1])
            
            return running_profit

        return max_profit_of_limited_options() if k < len(prices) // 2 else max_profit_of_unlimited_options()