class Solution:
    def atMostNGivenDigitSet(self, digits: List[str], n: int) -> int:
        n_str = str(n)
        memory: dict[tuple[pos: int, tight: bool, is_started: bool], combinations: int] = {}
        def atMostNGivenDigitSetRec(pos: int, tight: bool, is_started: bool) -> int:
            if pos == len(str(n)): return 1 if is_started else 0
            if (pos, tight, is_started) in memory: return memory[(pos, tight, is_started)]

            limit = int(str(n)[pos]) if tight else 9

            combinations = 0
            for d in digits:
                if int(d) > limit: continue
                combinations += atMostNGivenDigitSetRec(pos + 1, tight and int(d) == limit, True)

            if not is_started and pos < len(str(n)) - 1:
                combinations += atMostNGivenDigitSetRec(pos + 1, False, False)

            memory[(pos, tight, is_started)] = combinations

            return combinations

        return atMostNGivenDigitSetRec(0, True, False)
