class Solution:
    # Below version is for maximized constaints, where the scope of x goes high above, what's given originally for this task. I
    # have done it for the purposes of learning Digit DP approach. For the solution strictly related to this task's constraints
    #
    def sumOfGoodIntegers(self, n: int, k: int) -> int:
        @cache
        def sumOfIntegersRec(bit_pos: int) -> Tuple[suffixes_sum: int, suffixes_count: int]:
            if bit_pos == -1: return (0, 1)
            
            suffixes_sum, suffixes_count = 0,0
            for bit_value in (0, 1):
                if ((n >> bit_pos) & (bit_value)): continue

                tail_suffixes_sum, tail_suffixes_count = sumOfIntegersRec(bit_pos - 1)

                suffixes_sum += (bit_value * (1 << bit_pos) * tail_suffixes_count) + tail_suffixes_sum
                suffixes_count += tail_suffixes_count
            
            return (suffixes_sum, suffixes_count)

        def sumOfGoodIntegersRec(bit_pos: int, limit: int) -> Tuple[int, int]:
            if bit_pos == -1: return (0,1)

            current_bit_limit = (limit >> bit_pos) & 0x01

            suffixes_sum, suffixes_count = 0,0
            for bit_value in (0, 1):
                if bit_value > current_bit_limit or ((n >> bit_pos) & (bit_value)): continue

                tail_suffixes_sum, tail_suffixes_count = sumOfGoodIntegersRec(bit_pos - 1, limit) if bit_value == current_bit_limit else sumOfIntegersRec(bit_pos - 1)
                
                suffixes_sum += (bit_value * (1 << bit_pos) * tail_suffixes_count) + tail_suffixes_sum
                suffixes_count += tail_suffixes_count

            return suffixes_sum, suffixes_count

        return sumOfGoodIntegersRec(60, k + n)[0] - sumOfGoodIntegersRec(60, max(1, n - k) - 1)[0]

        # def sumOfGoodIntegersRec(bit_pos: int, tight: bool, limit: int) -> Tuple[int, int]:
        #     if bit_pos == -1:
        #         return (0,1)

        #     current_bit_limit = ((limit >> bit_pos) & 0x01) if tight else 1

        #     suffixes_sum, suffixes_count = 0,0
        #     for bit_value in (0, 1):
        #         if bit_value > current_bit_limit or ((n >> bit_pos) & (bit_value)): continue

        #         tail_suffixes_sum, tail_suffixes_count = sumOfGoodIntegersRec(bit_pos - 1, tight and current_bit_limit == bit_value, limit)
                
        #         suffixes_sum += (bit_value * (1 << bit_pos) * tail_suffixes_count) + tail_suffixes_sum
        #         suffixes_count += tail_suffixes_count

        #     return suffixes_sum, suffixes_count

        # return sumOfGoodIntegersRec(60, True, k + n)[0] - sumOfGoodIntegersRec(60, True, max(1, n - k) - 1)[0]

    # Below version is enough for given constaints and shuold be presented as the default solution for this particular LC task
    #
    # def sumOfGoodIntegers(self, n: int, k: int) -> int:
    #     return sum(x for x in range(max(1, n - k), k + n + 1) if n & x == 0)
