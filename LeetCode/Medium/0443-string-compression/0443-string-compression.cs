public class Solution {
    public int Compress(char[] chars) {
        var r = 0;
        var w = 0;

        while (r < chars.Length)
        {
            var c = r;

            while (r < chars.Length && chars[r] == chars[c]) r++;
            
            chars[w++] = chars[c];
            var count = r - c;
            if (count > 1)
            {
                count.TryFormat(chars.AsSpan(w), out int charsWritten);
                w += charsWritten;
            }
        }

        return w;
    }
}