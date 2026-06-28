class Solution:
    def generate(self, numRows: int) -> List[List[int]]:
        triangle = [[1]]
        for row in range(1, numRows):
            left_shifted = [0] + triangle[row - 1]
            right_shifted = triangle[row - 1] + [0]

            triangle.append([a + b for a, b in zip(left_shifted, right_shifted, strict=True)])
        
        return triangle