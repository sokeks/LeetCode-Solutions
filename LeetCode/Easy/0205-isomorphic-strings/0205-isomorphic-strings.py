class Solution:
    def isIsomorphic(self, s: str, t: str) -> bool:
        s_to_t_map = {}
        t_to_s_exist = set()

        for (s_char, t_char) in zip(s, t):
            if s_char in s_to_t_map:
                if s_to_t_map[s_char] != t_char:
                    return False
            else:
                if t_char in t_to_s_exist:
                    return False
                s_to_t_map[s_char] = t_char
                t_to_s_exist.add(t_char)

        return True