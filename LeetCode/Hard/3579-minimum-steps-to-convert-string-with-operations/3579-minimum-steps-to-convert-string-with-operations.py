class Solution:
    def minOperations(self, word1: str, word2: str) -> int:
        def count_swaps_and_replaces(source: str, target: str) -> int:
            pair_mismatches = [[0] * 26 for _ in range(26)]
            for s, t in zip(source, target):
                if s != t:
                    pair_mismatches[ord(s) - ord('a')][ord(t) - ord('a')] += 1
            
            operations_count = 0
            for i in range(26):
                for j in range(i + 1, 26):
                    operations_count += max(pair_mismatches[i][j], pair_mismatches[j][i])

            return operations_count

        dp = []
        for current_len in range(len(word1) + 1):
            min_operations = current_len
            for start in range(0, current_len):
                source = word1[start:current_len]
                target = word2[start:current_len]

                current_operations = dp[start] + min(count_swaps_and_replaces(source, target), 1 + count_swaps_and_replaces(source[::-1], target))
                min_operations = min(min_operations, current_operations)
                
            dp.append(min_operations)

        return dp[-1]