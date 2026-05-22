public class Solution {
    private const int EnglishAphabetSize = 26;
    public int FirstUniqChar(string s) {
        Span<int> frequencies = stackalloc int[EnglishAphabetSize];
        
        for (var i = 0; i < s.AsSpan().Length; i++)
        {
            var pos = s[i] - 'a';
            if (frequencies[pos] == 0)
            {
                frequencies[pos] = i + 1;
            }
            else
            {
                frequencies[pos] = -1;
            }
        }

        var index = 0;
        foreach (var f in frequencies)
        {
            if (f > 0 && (index == 0 || f < index))
            {
                index = f;
            }
        }
 
        return index - 1;
    }
}