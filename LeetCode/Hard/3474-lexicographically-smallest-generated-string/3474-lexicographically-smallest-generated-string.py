class Solution:
    def generateString(self, str1: str, str2: str) -> str:
        len_str2 = len(str2)
        result = ['a'] * (len(str1) + len_str2 - 1)
        committed = set()

        for i, c in enumerate(str1):
            if c == 'F':
                continue
            for j in range(len_str2):
                w = i + j
                if w in committed and result[w] != str2[j]:
                    return ""
                result[w] = str2[j]
                committed.add(w)
        
        str2_list = list(str2)
        for i, c in enumerate(str1):
            if c == 'T' or result[i:i + len_str2] != str2_list:
                continue
            
            for j in range(len_str2 - 1, -1, -1):
                rightmost_idx = i + j
                if not rightmost_idx in committed:
                    result[rightmost_idx] = 'b'
                    committed.add(rightmost_idx)
                    break
            else:
                return ""
        
        return "".join(result)