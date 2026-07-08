class Solution:
    LETTERS_COUNT = 26
    def convertToTitle(self, columnNumber: int) -> str:
        current_col_number_part = columnNumber
        column_title = []

        while current_col_number_part:
            current_col_number_part -= 1
            val = current_col_number_part % self.LETTERS_COUNT
            column_title.append(chr(ord("A") + val))
            current_col_number_part //= self.LETTERS_COUNT

        return "".join(reversed(column_title))
        