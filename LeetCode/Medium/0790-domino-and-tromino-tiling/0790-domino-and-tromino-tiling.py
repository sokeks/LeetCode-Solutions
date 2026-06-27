# We want to reach flat wall at the end, so we search F(i)
#
# To build flat wall F(i) we either: a) add one vertical domino from F(i - 1) or b) add 2 horizonta dominos from F(i - 2) or
# c) add 1 tromino from top partial wall P(i - 1) or d) add 1 tromino from down partial wall P(i - 1) ( c) & d) calculate exactly same) 
# This gives us: F(i) = F(i - 1) + F(i - 2) + P(i - 1) + P(i - 1) = F(i - 1) + F(i - 2) + 2 * P(i - 1) of all combinations (important to mental model it)
#  
# To build P(i), we either a) add 1 tromino from flat wall F(i - 2) or b) add one horizontal domino from partial wall P(i - 1)
# That gives us: P(i) = F(i - 2) + P(i - 1)
#
# Compacting:   F(i) = F(i - 1) + F(i - 2) + 2 * P(i - 1) 
# one older:    F(i - 1) = F(i - 2) + F(i - 3) + 2 * P(i - 2)
# subtracting:  F(i) - F(i - 1) = F(i - 1) + F(i - 2) + 2 * P(i - 1) - F(i - 2) - F(i - 3) - 2 * P(i - 2)
# tidying:      F(i) = 2 * F(i - 1) - F(i - 3) + 2 * (P(i - 1) - P(i - 2))
# transforming: P(i) = F(i - 2) + P(i - 1) -> P(i) - P(i - 1) = F(i - 2) -> P(i - 1) - P(i - 2) = F(i - 3)
# replacing:    F(i) = 2 * F(i - 1) - F(i - 3) + 2 * F(i - 3) -> F(i) = 2 * F(i - 1) + F(i - 3) <- FINAL EQUATION
class Solution:
    def numTilings(self, n: int) -> int:
        flat_minus_3 = 1                # F(-1) -> empty board
        flat_minus_2 = 1                # F(0) -> 1 vertical domino
        flat_minus_1 = 2                # F(1) -> 2 horizontal dominos or 2 vertical dominos
        if n == 1: return flat_minus_2
        if n == 2: return flat_minus_1

        for i in range(2, n):
            flat_minus_3, flat_minus_2, flat_minus_1 = flat_minus_2, flat_minus_1, (2 * flat_minus_1 + flat_minus_3) % (10 ** 9 + 7)

        return flat_minus_1


        