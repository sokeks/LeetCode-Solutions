class Solution:
    def atMostNGivenDigitSet(self, digits: List[str], n: int) -> int:
        n_str = str(n)

        @cache
        def atMostNGivenDigitSetRec(pos: int, tight: bool, was_first_digit_placed: bool) -> int:
            if pos == len(n_str): return 1 if was_first_digit_placed else 0

            limit = n_str[pos] if tight else "9"

            combinations = 0
            for d in digits:
                if d > limit: break
                combinations += atMostNGivenDigitSetRec(pos + 1, tight and d == limit, True)

            if not was_first_digit_placed:
                combinations += atMostNGivenDigitSetRec(pos + 1, False, False)

            return combinations

        return atMostNGivenDigitSetRec(0, True, False)
