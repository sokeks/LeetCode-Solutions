class Solution:
    def generate(self, numRows: int) -> List[List[int]]:
        triangle = [[1]]
        for row in range(1, numRows):
            right_shifted = triangle[row - 1] + [0]

            triangle.append([a + b for a, b in 
                zip(itertools.chain([0], triangle[row - 1]), itertools.chain(triangle[row - 1], [0]))]) 
        
        return triangle