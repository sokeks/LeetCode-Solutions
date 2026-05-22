public class Solution {
    public int LongestPalindrome(string s) {
        const int AsciiSize = 128;
        Span<int> frequencies = stackalloc int[AsciiSize]; // frequencies for A-Z and a-z

        foreach (var c in s.AsSpan())
        {
            frequencies[c]++;
        }

        var length = 0;
        foreach (var f in frequencies)
        {
            length += f & ~1;
        }
        
        return length < s.Length ? length + 1 : length;
    }
}