class Solution:
    # this task is a modification of "583. Delete Operation for Two Strings" (see there for more explanations), when one has to just calculate min
    # number of operations, here it's minimum sum of ascii
    def minimumDeleteSum(self, s1: str, s2: str) -> int:
        asciis_1, asciis_2 = (ord(s1[i]) for i in range(len(s1))), (ord(s2[i]) for i in range(len(s2)))
        asciis_sum_1, asciis_sum_2 = list(accumulate(asciis_1, initial=0)), list(accumulate(asciis_2, initial=0))

        @cache
        def minimumDeleteSum_rec(i_1: int, i_2: int):
            if i_1 == 0:
                return asciis_sum_2[i_2]
            if i_2 == 0:
                return asciis_sum_1[i_1]
            
            if s1[i_1 - 1] == s2[i_2 - 1]:
                return minimumDeleteSum_rec(i_1 - 1, i_2 - 1)
            else:
                return min(ord(s1[i_1 - 1]) + minimumDeleteSum_rec(i_1 - 1, i_2), ord(s2[i_2 - 1]) + minimumDeleteSum_rec(i_1, i_2 - 1))
        
        return minimumDeleteSum_rec(len(s1), len(s2))
            

    # iterative version, memory optimal
    # target -> columns
    # source -> rows
        source, target = (s1, s2) if len(s1) >= len(s2) else (s2, s1)
        source_len, target_len = len(source), len(target)

        ascii_values = (ord(target[i]) for i in range(target_len))
        dp = list(accumulate(ascii_values, initial=0))

        for i in range(1, source_len + 1):
            prev_diagonal, dp[0] = dp[0], dp[0] + ord(source[i - 1])

            for j in range(1, target_len + 1):
                prev_diagonal, dp[j] = dp[j], prev_diagonal if source[i - 1] == target[j - 1] else min(ord(target[j - 1]) + dp[j - 1], ord(source[i - 1]) + dp[j])
        
        return dp[-1]