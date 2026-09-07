class Solution:
    def clearStars(self, s: str) -> str:
        chars_positions:dict[str, deque[int]] = defaultdict(deque)
        sorted_chars = []

        result = list(s)
        for i, c in enumerate(result):
            if c == '*':
                smallest = sorted_chars[0]
                result[chars_positions[smallest].pop()] = '*'
                if not chars_positions[smallest]:
                    heapq.heappop(sorted_chars)
            else:
                if not chars_positions[c]:
                    heapq.heappush(sorted_chars, c)
                
                chars_positions[c].append(i)

        return "".join(c for c in result if c != '*')