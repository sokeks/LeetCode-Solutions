class Solution:
    def romanToInt(self, s: str) -> int:
        mapping = {"I" : 1, "V" : 5, "X" : 10, "L" : 50, "C" : 100, "D" : 500, "M" : 1000}

        integer = 0
        previous_char_val = mapping["M"]
        for c in s:
            c_int = mapping[c]
            integer += c_int
            if c_int > previous_char_val:
                integer -= (2 * previous_char_val)
        
            previous_char_val = c_int
            
        return integer
        