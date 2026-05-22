public class Solution {
    public int RomanToInt(string s) {
        var lastValue = 0;
        var result = 0;
        for (var ii = s.Length - 1; ii >= 0; --ii)
        {
            var currentValue = GetValue(s[ii]);
            if (currentValue >= lastValue)
            {
                result += currentValue;
            }
            else
            {
                result -= currentValue;
            }
            lastValue = currentValue;
        }
        return result;
    }


    private int GetValue(char c) {
        return c switch {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0 // Fallback, choć w zadaniu zakładamy poprawny input
        };
    }
}