class Solution:
    def clearStars(self, s: str) -> str:
        occurrences:dict[str, list[int]] = defaultdict(list)
        smallests = []

        result_pattern = list(s)
        for i, c in enumerate(result_pattern):
            if c == '*':
                candidate = smallests[0]
                result_pattern[-heapq.heappop(occurrences[candidate])] = '*'
                if len(occurrences[candidate]) == 0:
                    heapq.heappop(smallests)
            else:
                if len(occurrences[c]) == 0:
                    heapq.heappush(smallests, c)
                
                heapq.heappush(occurrences[c], -i)


        return "".join(c for c in result_pattern if c != '*')

        