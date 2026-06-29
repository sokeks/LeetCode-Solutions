class Solution:
    def getRow(self, rowIndex: int) -> List[int]:
        row = [1]

        for i in range(1, rowIndex + 1):
            left_shifted = itertools.chain((0,), row)
            right_shifted = itertools.chain(row, (0,))

            row = [a + b for a, b in zip(left_shifted, right_shifted)]
            

        return row