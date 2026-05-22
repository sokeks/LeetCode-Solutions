public class Solution {
    private const int englishAlphaLettersCount = 26;
    public bool WordPattern(string pattern, string s) {
        var p2sMap = new (int begin, int length)[englishAlphaLettersCount];

        var si = 0;
        foreach (var p in pattern)
        {
            if (si >= s.Length) return false;

            var spaceIdx = s.AsSpan(si).IndexOf(' ');
            var curWordLength = spaceIdx != -1 ? spaceIdx : s.Length - si;
            var curWord = s.AsSpan(si, curWordLength);

            var (oldWordIdx, oldWordLength) = p2sMap[p - 'a'];
            if (oldWordLength == 0)
            {
                foreach(var p2s in p2sMap)
                {
                    if (p2s.length == 0) continue;

                    var oldWord = s.AsSpan(p2s.begin, p2s.length);
                    if (oldWord.SequenceEqual(curWord))
                    {
                        return false;
                    }
                }
                p2sMap[p - 'a'] = (si, curWordLength);
            }
            else if (!s.AsSpan(oldWordIdx, oldWordLength).SequenceEqual(curWord))
            {
                return false;
            }
            si += curWordLength + 1;
        }

        return si == s.Length + 1;
    }
}