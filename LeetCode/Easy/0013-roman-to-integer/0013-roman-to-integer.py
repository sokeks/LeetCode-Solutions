class Solution:
    _ROMAN_VALUES_TO_DEC = {"I" : 1, "V" : 5, "X" : 10, "L" : 50, "C" : 100, "D" : 500, "M" : 1000}
    def romanToInt(self, s: str) -> int:
        integer = 0
        
        previous_char_val = 0
        for c in reversed(s):
            c_int = self._ROMAN_VALUES_TO_DEC[c]
            if c_int < previous_char_val:
                integer -= c_int
            else:
                integer += c_int
            previous_char_val = c_int

        return integer




        previous_char_val = self._ROMAN_VALUES_TO_DEC["M"]
        for c in s:
            c_int = self._ROMAN_VALUES_TO_DEC[c]
            integer += c_int
            if c_int > previous_char_val:
                integer -= (2 * previous_char_val)
        
            previous_char_val = c_int

        return integer
        