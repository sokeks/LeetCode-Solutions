# Wrote all cases from 1 to 11 and found that on even Alice wins, while on odd Bob wins, however it's not enough...
# Rules:
# 1. Ending up at n = 1 means loosing
# 2. Having odd one has to pass to the second player even, as all odd divisors has to be odd, and odd_number_1 - odd_number_2 = even
# 3. Having even, one can always pass to the second player odd, by choosing the divisor = 1
# 4. By 2. & 3., someone starting with odd can be forced to always get back odd and keeping this will make one go eventally to 1, which by 1. looses
# Therefore, if Alice starts with odd, she will eventually fail. This pure analytical mathematical solution represented by n % 2 == 0
#
# However, if one wants to check a result using DP, see code below. In it, assuming n == 1 means always loose of Alice, we want to find if Alice
# can give to Bob such a number, that will means his loosing. We do it by calculating all game results from start value == 2 up to n and return result for n

class Solution:
    # # Optimal O(1) calculation and memory solution
    # def divisorGame(self, n: int) -> bool:
    #     return n % 2 == 0
    
    # DP solution O(n^2) calculation and O(n) memory
    def divisorGame(self, n: int) -> bool:
        is_alice_winning = [False] * (n + 1)
        for interim_n in range (2, n + 1):
            for x in range (1, interim_n // 2 + 1):
                is_valid_move = (interim_n % x == 0)
                if not is_valid_move: continue

                makes_bob_loosing = not is_alice_winning[interim_n - x]
                if makes_bob_loosing:
                    is_alice_winning[interim_n] = True
                    break

        return is_alice_winning[n]
