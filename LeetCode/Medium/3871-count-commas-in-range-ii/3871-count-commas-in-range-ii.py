class Solution:
    def countCommas(self, n: int) -> int:
        commas_count = 0
        threshold = 1000

        while threshold <= n:
            commas_count += n - threshold + 1
            threshold *= 1000
        
        return commas_count

        