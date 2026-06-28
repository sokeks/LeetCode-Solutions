class Solution:
    def generate(self, numRows: int) -> List[List[int]]:
        rows = []
        for r in range(numRows):
            row = [1] * (r + 1)
            for i in range(1, r):
                row[i] = rows[r - 1][i - 1] + rows[r - 1][i]
            rows.append(row)
        
        return rows





        