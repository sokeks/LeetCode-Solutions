public class Solution {
    private const int englishAlphabetSize = 26;
    public bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote.Length > magazine.Length) return false;
         
        Span<int> occurred = stackalloc int[englishAlphabetSize];

        foreach (var c in magazine.AsSpan())
        {
            occurred[c - 'a']++;
        }

        foreach (var c in ransomNote.AsSpan())
        {
            var pos = c - 'a';
            occurred[pos]--;
            if (occurred[pos] < 0)
            {
                return false;
            }
        }

        return true;
    }
}