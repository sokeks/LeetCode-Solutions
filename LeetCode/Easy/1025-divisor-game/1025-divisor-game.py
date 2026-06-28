# Wrote all cases from 1 to 11 and found that on even Alice wins, while on odd Bob wins, however it's not enough...
# Rules:
# 1. Ending up at n = 1 means loosing
# 2. Having odd one has to pass to the second player even, as all odd divisors has to be odd, and odd_number_1 - odd_number_2 = even
# 3. Having even, one can always pass to the second player odd, by choosing the divisor = 1
# 4. By 2. & 3., someone starting with odd can be forced to always get back odd and keeping this will make one go eventally to 1, which by 1. looses
# Therefore, if Alice starts with odd, she will eventually fail

class Solution:
    def divisorGame(self, n: int) -> bool:
        return n % 2 == 0