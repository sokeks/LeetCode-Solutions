class Solution:
    def atMostNGivenDigitSetRec(self, digits: List[str], n: int, memory: dict[tuple[pos: int, tight: bool, is_started: bool], combinations: int], pos: int, tight: bool, is_started: bool) -> int:
        if pos == len(str(n)): return 1
        if (pos, tight, is_started) in memory: return memory[(pos, tight, is_started)]

        limit = int(str(n)[pos]) if tight else 9

        combinations = 0
        for d in digits:
            if int(d) > limit: continue
            combinations += self.atMostNGivenDigitSetRec(digits, n, memory, pos + 1, tight and int(d) == limit, True)

        if not is_started and pos < len(str(n)) - 1:
            combinations += self.atMostNGivenDigitSetRec(digits, n, memory, pos + 1, False, False)

        memory[(pos, tight, is_started)] = combinations

        return combinations


    def atMostNGivenDigitSet(self, digits: List[str], n: int) -> int:
        memory = {}
        return self.atMostNGivenDigitSetRec(digits, n, memory, 0, True, False)
