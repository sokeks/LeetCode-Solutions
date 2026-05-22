public class Solution {
    public string ReverseWords(string s) {
        Span<char> ss = stackalloc char[s.Length];

        var inI = s.Length - 1;
        var outI = 0;

        while (inI >= 0)
        {
            if (s[inI] == ' ')
            {
                inI--;
            }
            else
            {
                var end = inI + 1;
                while (inI >= 0 && s[inI] != ' ') inI--;

                var start = inI + 1;

                if (outI > 0)
                {
                    ss[outI++] = ' ';
                }

                s.AsSpan(start, end - start).CopyTo(ss.Slice(outI, end - start));
                outI += end - start;
            }
        }

        return new string(ss[..outI]);
    }
}