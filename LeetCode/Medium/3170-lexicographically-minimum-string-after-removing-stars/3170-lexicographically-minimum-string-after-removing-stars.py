class Solution:
    def clearStars(self, s: str) -> str:
        chars_positions: dict[str, list[int]] = defaultdict(list)
        available_chars_heap = []

        result = list(s)
        for i, c in enumerate(result):
            if c == '*':
                char = available_chars_heap[0]
                result[chars_positions[char].pop()] = '*'
                if not chars_positions[char]:
                    heapq.heappop(available_chars_heap)
            else:
                if not chars_positions[c]:
                    heapq.heappush(available_chars_heap, c)
                
                chars_positions[c].append(i)

        return "".join(c for c in result if c != '*')