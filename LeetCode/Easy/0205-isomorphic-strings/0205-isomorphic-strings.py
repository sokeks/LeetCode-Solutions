class Solution:
    def isIsomorphic(self, s: str, t: str) -> bool:
        ASCII_COUNT = 255
        s_to_t_map = ['\0'] * ASCII_COUNT
        s_to_t_exist = [False] * ASCII_COUNT
        t_to_s_map = ['\0'] * ASCII_COUNT
        t_to_s_exist = [False] * ASCII_COUNT

        for (ac, tc) in zip(s, t):
            if s_to_t_exist[ord(ac)]:
                if s_to_t_map[ord(ac)] != tc:
                    return False
            else:
                if t_to_s_exist[ord(tc)]:
                    return False
                s_to_t_exist[ord(ac)] = True
                s_to_t_map[ord(ac)] = tc
                t_to_s_exist[ord(tc)] = True


        return True
