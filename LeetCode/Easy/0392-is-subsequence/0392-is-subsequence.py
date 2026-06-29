class Solution:
    def __init__(self):
        self.char_to_indexes_map = None
        self.t = None

    def _create_char_to_indexes_map(self, t:str) -> dict[str, list[int]]:
        char_to_indexes_map = defaultdict(list)
        for i, t_char in enumerate(t):
            char_to_indexes_map[t_char].append(i)
        return char_to_indexes_map
    
    def _binary_search_next_char_index_position(self, char_indexes: list[int], previous_t_index: int):
        left = 0
        right = len(char_indexes)
        while left < right:
            mid = left + (right - left) // 2

            if char_indexes[mid] <= previous_t_index: left = mid + 1
            else: right = mid

        return left

    def isSubsequence(self, s: str, t: str) -> bool:
        if not s: return True
        if len(s) > len(t): return False

        if self.char_to_indexes_map is None or self.t != t:
            self.char_to_indexes_map = self._create_char_to_indexes_map(t)
            self.t = t
        
        previous_t_index = -1

        for s_char in s:
            if s_char not in self.char_to_indexes_map: return False
            char_indexes = self.char_to_indexes_map[s_char]
            char_indexes_position = self._binary_search_next_char_index_position(char_indexes, previous_t_index)

            if char_indexes_position == len(char_indexes): return False

            previous_t_index = char_indexes[char_indexes_position]

        return True


    # # standard, not a follow-up solution
    # def isSubsequence(self, s: str, t: str) -> bool:
    #     if not s: return True
    #     if len(s) > len(t): return False

    #     s_ptr = 0
    #     for t_char in t:
    #         if t_char != s[s_ptr]: continue
    
    #         s_ptr += 1
    #         if s_ptr == len(s): return True

    #     return False