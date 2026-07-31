class Solution:
    def maximumProfit(self, prices: List[int], k: int) -> int:
        bought_stock = [-prices[0]] * k
        short_sold_stock = [prices[0]] * k
        no_stock = [0] * (k + 1)

        for p in islice(prices, 1, None):
            for i in range(1, len(bought_stock) + 1):
                no_stock[k + 1 - i] = max(no_stock[k + 1 - i], bought_stock[k - i] + p, short_sold_stock[k - i] - p)
                bought_stock[k - i] = max(bought_stock[k - i], no_stock[k - i] - p)
                short_sold_stock[k - i] = max(short_sold_stock[k - i], no_stock[k - i] + p)
        
        return max(no_stock)