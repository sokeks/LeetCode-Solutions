class Solution:
    def findMinimumOperations(self, s1: str, s2: str, s3: str) -> int:
        shortest_len = min(len(s1), len(s2), len(s3))
        
        for i in range(shortest_len):
            if not (s1[i] == s2[i] == s3[i]):
                break
        else:
            i += 1
        
        return -1 if i == 0 else len(s1) + len(s2) + len(s3) - 3 * i