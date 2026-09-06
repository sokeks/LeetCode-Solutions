class Solution:
    def generateString(self, str1: str, str2: str) -> str:
        result = ['a'] * (len(str1) + len(str2) - 1)
        set_idxs = set()

        for i, c in enumerate(str1):
            if c == 'F':
                continue
            for j in range(len(str2)):
                w = i + j
                if w in set_idxs and result[w] != str2[j]:
                    return ""
                result[w] = str2[j]
                set_idxs.add(w)
        
        str2_list = list(str2)
        for i, c in enumerate(str1):
            if c == 'T' or result[i:i + len(str2)] != str2_list:
                continue
            
            for j in range(len(str2) - 1, -1, -1):
                rightmost_idx = i + j
                if not rightmost_idx in set_idxs:
                    result[rightmost_idx] = 'b'
                    set_idxs.add(rightmost_idx)
                    break
            else:
                return ""
        
        return "".join(result)