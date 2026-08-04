class Solution:
    def findMinimumOperations(self, s1: str, s2: str, s3: str) -> int:
        shortest_len = min(len(s1), len(s2), len(s3))
        
        common_prefix_len = 0
        for i in range(shortest_len):
            if not (s1[i] == s2[i] == s3[i]):
                common_prefix_len = i
                break
        else:
            common_prefix_len += (i + 1)
        
        return -1 if common_prefix_len == 0 else len(s1) + len(s2) + len(s3) - 3 * common_prefix_len