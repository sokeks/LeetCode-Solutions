public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Span<char> sMap = stackalloc char[128];
        Span<char> tMap = stackalloc char[128];
        for (var i = 0; i < s.Length; i++)
        {
            var si = s[i];
            var ti = t[i];
            if (tMap[ti] == '\0' && sMap[si] == '\0')
            {
                tMap[ti] = si;
                sMap[si] = ti;
            }
            else if (sMap[si] != ti || tMap[ti] != si)
            {
                return false;
            }
        }
        
        return true;
    }
}