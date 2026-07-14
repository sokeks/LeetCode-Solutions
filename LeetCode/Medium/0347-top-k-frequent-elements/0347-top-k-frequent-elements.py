class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        num_to_freqs: dict[int, int] = defaultdict(int)
        freq_to_nums: list[list[int]] = [[] for _ in range(len(nums) + 1)]
        idx = 0
        while idx < len(nums):
            anchor = idx
            current_num = nums[anchor]
            while idx < len(nums) and nums[idx] == current_num:
                idx += 1
            
            num_to_freqs[current_num] += (idx - anchor)
            freq_to_nums[num_to_freqs[current_num]].append(current_num)
        
        idx = len(freq_to_nums) - 1
        top_k_freqs = set()
        while idx >= 0 and len(top_k_freqs) < k:
            top_k_freqs.update(freq_to_nums[idx])
            idx -= 1

        return list(top_k_freqs)


        # O N logK (due to last loop) approach, sufficient for this task
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