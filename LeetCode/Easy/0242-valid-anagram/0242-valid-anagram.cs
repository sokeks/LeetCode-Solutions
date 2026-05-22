public class Solution {
    private const int LowercaseEnglishLettersNum = 26;

    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        
        var chars = new int[LowercaseEnglishLettersNum];

        foreach (var c in s.AsSpan())
        {
            chars[c - 'a'] += 1;
        }

        foreach (var c in t.AsSpan())
        {
            chars[c - 'a'] -= 1;
            if (chars[c - 'a'] < 0)
            {
                return false;
            }
        }

        return true;
    }

    // follow up question: I would consider using Dictionary in case values are sparse, but in general I would stay with an array, as in typical conditions it would take 65k * 4 B ~ 256kB, which is still ok
    // using Dictionary will make the cache misses and page invalidation. Additionally, Unicode can take up to 4 chars for one element, so one would need to use StringInfo.GetTextElementEnumerator(s)
}