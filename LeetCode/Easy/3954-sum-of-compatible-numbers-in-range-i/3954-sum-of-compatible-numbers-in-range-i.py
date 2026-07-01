class Solution:
    def sumOfGoodIntegers(self, n: int, k: int) -> int:
        @cache
        def sumOfGoodIntegersRec(bit_pos: int, tight: bool, limit: int) -> Tuple[int, int]:
            if bit_pos == -1:
                # print("return (0,1)")
                return (0,1)

            current_bit_limit = ((limit >> bit_pos) & 0x01) if tight else 1
            # print(f"bit_pos={bit_pos} ; (limit >> bit_pos) & 0x01)={((limit >> bit_pos) & 0x01)} current_bit_limit={current_bit_limit}")

            sufixes_sum, sufixes_count = 0,0
            for bit_value in (0, 1):
                if bit_value > current_bit_limit or ((n >> bit_pos) & (bit_value)): continue

                # padding = "x" * bit_pos
                # print(f"{bits}{bit_value}{padding}")
                lower_sufixes_sum, lower_sufixes_count = sumOfGoodIntegersRec(bit_pos - 1, tight and current_bit_limit == bit_value, limit)
                sufixes_sum += (bit_value * (1 << bit_pos) * lower_sufixes_count) + lower_sufixes_sum
                sufixes_count += lower_sufixes_count
                # print(f"{bits}{bit_value}{padding}: sufixes_sum={sufixes_sum} ; sufixes_count={sufixes_count}; limit={limit:b}")

            return sufixes_sum, sufixes_count

        # return sumOfGoodIntegersRec(2, True, 5, "")
        return sumOfGoodIntegersRec(60, True, k + n)[0] - sumOfGoodIntegersRec(60, True, max(1, n - k) - 1)[0]


    # def sumOfGoodIntegers(self, n: int, k: int) -> int:
    #     return sum(x for x in range(max(1, n - k), k + n + 1) if n & x == 0)
