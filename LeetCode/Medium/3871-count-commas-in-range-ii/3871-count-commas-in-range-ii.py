class Solution:
    def countCommas(self, n: int) -> int:
        commas_count = 0
        lower = 1000
        commas_in_number = 1

        while lower <= n:
            commas_count += (min(n, lower * 1000 - 1) - lower + 1) * commas_in_number
            lower *= 1000
            commas_in_number += 1



        # commas_count = 0
        # threshold = 1000

        # while threshold <= n:
        #     commas_count += n - threshold + 1
        #     threshold *= 1000
        
        return commas_count

        