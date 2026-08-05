class Solution:
    def lengthOfLIS(self, nums: List[int]) -> int:
    # O(n log n) time complexity + O(n) space complexit version
        def substitute_first_bigger(l: list[int], n: int):
            left = 0
            right = len(l)
            while left < right:
                mid = (left + right) // 2
                if l[mid] < n:
                    left = mid + 1
                else:
                    right = mid

            l[left] = n

        subsequence_tails = [nums[0]]

        for n in islice(nums, 1, None):
            if n > subsequence_tails[-1]:
                subsequence_tails.append(n)
            else:
                idx = bisect.bisect_left(subsequence_tails, n)
                subsequence_tails[idx] = n
                # substitute_first_bigger(subsequence_tails, n)
        
        return len(subsequence_tails)


    # O(n^2) time complexity version + O(n) space complexity - easier version
        dp = [0] * len(nums)

        for i, n in enumerate(nums):
            max_subsequence_len = 0
            for j, m in enumerate(islice(nums, 0, i)):
                if n > m and dp[j] > max_subsequence_len:  
                    max_subsequence_len = dp[j]
            dp[i] = 1 + max_subsequence_len

        return max(dp)
        