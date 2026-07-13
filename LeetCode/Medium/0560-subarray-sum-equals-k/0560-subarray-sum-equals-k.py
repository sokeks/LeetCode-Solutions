class Solution:
    def subarraySum(self, nums: List[int], k: int) -> int:
        prefixsums_to_occurrences_map = defaultdict(int)
        prefixsums_to_occurrences_map[0] = 1
        subarrays_count = 0
        running_sum = 0
        for n in nums:
            running_sum += n
            # running_sum - prefix = k -> running_sum - k = prefix
            subarrays_count += prefixsums_to_occurrences_map[running_sum - k]
            prefixsums_to_occurrences_map[running_sum] += 1

        return subarrays_count