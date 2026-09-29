class Solution:
    def numDecodings(self, s: str) -> int:
        if s[0] == '0':
            return 0
        decode_ways_2_less = 1
        decode_ways_1_less = 1

        for i in range(1, len(s)):
            decode_ways_for_1_digit_now = decode_ways_1_less if s[i] > '0' else 0
            decode_ways_for_2_digits_now = decode_ways_2_less if s[i - 1] == '1' or (s[i - 1] == '2' and s[i] <= '6') else 0
            
            if decode_ways_for_1_digit_now == 0 and decode_ways_for_2_digits_now == 0:
                return 0
            
            decode_ways_2_less, decode_ways_1_less = decode_ways_1_less, decode_ways_for_1_digit_now + decode_ways_for_2_digits_now

        return decode_ways_1_less