class Solution:
    def atMostNGivenDigitSet(self, digits: List[str], n: int) -> int:
        n_str = str(n)

        @cache
        def atMostNGivenDigitSetRec(pos: int, tight: bool, is_started: bool) -> int:
            if pos == len(n_str): return 1 if is_started else 0

            limit = n_str[pos] if tight else "9"

            combinations = 0
            for d in digits:
                if d > limit: break
                combinations += atMostNGivenDigitSetRec(pos + 1, tight and d == limit, True)

            if not is_started:
                combinations += atMostNGivenDigitSetRec(pos + 1, False, False)

            return combinations

        return atMostNGivenDigitSetRec(0, True, False)
