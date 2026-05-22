public class Solution {
    public char FindTheDifference(string s, string t) {
        var result = 0;

        foreach (var c in s.AsSpan())
        {
            result ^= c;
        }

        foreach (var c in t.AsSpan())
        {
            result ^= c;
        }

        return (char)result;
    }
}