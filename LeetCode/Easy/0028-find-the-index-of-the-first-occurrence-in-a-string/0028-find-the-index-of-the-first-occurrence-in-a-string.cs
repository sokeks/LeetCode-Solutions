public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle.Length > haystack.Length)
        {
            return -1;
        }
        if (haystack == needle)
        {
            return 0;
        }

        var lps = BuildLps(needle);
        var n = 0;
        var i = 0;
        while (i < haystack.Length)
        {
            if (haystack[i] == needle[n])
            {
                i++;
                n++;
            }

            if (n == needle.Length)
            {
                return i - n;
                // n = lps[n - 1];
            }
            else if (i < haystack.Length && haystack[i] != needle[n])
            {
                if (n > 0)
                {
                    n = lps[n - 1];
                }
                else
                {
                    i++;
                }
            }
        }

        return -1;
    }

    private int[] BuildLps(string s)
    {
        var lps = new int[s.Length];
        var psLen = 0;
        var i = 1;

        while (i < s.Length)
        {
            if (s[i] == s[psLen])
            {
                psLen++;
                lps[i] = psLen;
                i++;
            }
            else
            {
                if (psLen > 0)
                {
                    psLen = lps[psLen - 1];
                }
                else
                {
                    lps[i] = 0;
                    i++;
                }
            }
        }

        return lps;
    }
}