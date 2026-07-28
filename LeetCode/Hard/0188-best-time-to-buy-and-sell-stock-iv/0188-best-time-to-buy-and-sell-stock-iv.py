class Solution:
    def maxProfit(self, k: int, prices: List[int]) -> int:
        bought_stocks = [-prices[0]] * k
        sold_stocks = [0] * (k + 1)

        for p in islice(prices, 1, None):
            for i in range(k):
                sold_stocks[i] = max(bought_stocks[i] + p, sold_stocks[i])
                bought_stocks[i] = max(sold_stocks[i + 1] - p, bought_stocks[i])

        return max(sold_stocks)
        