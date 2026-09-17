class Solution:
    def countCommas(self, n: int) -> int:
        commas_count = 0
        threshold = 1000

        while threshold <= n:
            commas_count += n - threshold + 1
            threshold *= 1000
        
        return commas_count

        def get_order_of_magnitude(n: int) -> n:
            return int(math.log(n, 1000))

        div, mod = divmod(n, 1000)
        if div == 0:
            return 0
        
        order_of_magnitude = get_order_of_magnitude(n)

        commas_count = 0
        for order in orders_of_magnitude:
            commas_count += (n - 1000**(order + 1))

        
        base = 1000 ** order_of_magnitude

        return (div - 1) * 1000 + order_of_magnitude * ((mod + 1) + (n - (n // base) * base - mod) // 1000)
        