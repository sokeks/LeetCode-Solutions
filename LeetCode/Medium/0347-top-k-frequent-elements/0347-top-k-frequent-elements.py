class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        # O
        frequencies: dict[int, int] = Counter(nums)

        freq_to_nums: list[list[int]] = [[] for _ in range(len(nums) + 1)]
        for num, freq in frequencies.items():
            freq_to_nums[freq].append(num)

        top_k_freqs = []
        for bucket in reversed(freq_to_nums):
            for item in bucket:
                top_k_freqs.append(item)
                if len(top_k_freqs) == k:
                    return top_k_freqs


        # O (N logK) (due to last loop) approach, sufficient for this task
        frequencies: dict[int, int] = defaultdict(int)
        
        for n in nums:
            frequencies[n] += 1
        
        top_k_freqs: list[tuple[int, int]] = []

        for num, freq in frequencies.items():
            if len(top_k_freqs) < k:
                heapq.heappush(top_k_freqs, (freq, num))
            elif top_k_freqs[0][0] < freq:
                heapq.heapreplace(top_k_freqs, (freq, num))
        
        return [num for freq, num in top_k_freqs]


        # pythonic, optimized by the Counter that calculates freq of each element in the collection
        return [num for num, freq in Counter(nums).most_common(k)]