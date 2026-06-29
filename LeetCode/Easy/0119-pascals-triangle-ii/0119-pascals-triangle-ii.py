
class Solution:
    # # classic, DP solution
    # def getRow(self, rowIndex: int) -> List[int]:
    #     row = [1] * (rowIndex + 1)

    #     for r in range(2, rowIndex + 1):
    #         for c in range(r - 1, 0, -1):
    #             row[c] += row[c - 1]
            
    #     return row

    # binomial coefficient solution
    def getRow(self, rowIndex: int) -> List[int]:
        row = [1] * (rowIndex + 1)
        
        for i in range(1, rowIndex + 1):
            # Multiply first, then integer division to prevent truncation
            row[i] = row[i - 1] * (rowIndex - i + 1) // i
            
        return row