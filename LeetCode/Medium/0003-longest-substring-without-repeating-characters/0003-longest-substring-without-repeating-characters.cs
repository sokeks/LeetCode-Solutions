public class Solution {
    public HashSet<char> Add(HashSet<char> set, char c)
    {
        set.Add(c);
        return set;
    }

    public int LengthOfLongestSubstring(string s) {
        var maxLength = 0;
        var currentLength = 0;
        var chars = new bool[128];

        var front = 0;
        var back = 0;

        while (front < s.Length)
        {
            if (!chars[(int)s[front]])
            {
                chars[(int)s[front]] = true;
                currentLength += 1;
            }
            else
            {
                maxLength = currentLength > maxLength ? currentLength : maxLength;
                while (chars[s[front]] && back < front)
                {
                    chars[s[back]] = false;
                    currentLength -= 1;
                    back++;
                }
                chars[(int)s[front]] = true;
                currentLength += 1;
            }

            front += 1;
        }
        maxLength = currentLength > maxLength ? currentLength : maxLength;

        return maxLength;

        // do
        // {

        // } while (++front == )

        // for (var ii = 0; ii < s.Length; ++ii)
        // {
        //     for (var jj = 0; jj < s.Length; ++jj)
        //     {
        //         if (!chars.Contains(s[jj]))
        //         {
        //             chars.Add(s[jj]);
        //             ++currentLength;
        //         }
        //         else
        //         {
        //             chars.Remove(s[ii]);
        //             maxLength = currentLength > maxLength ? currentLength : maxLength;
        //         }
        //     }
        // }

        return 0;







        var foundChars = new Dictionary<int, HashSet<char>>();
        for (var ii = 0; ii < s.Length; ++ii)
        {
            foundChars.Add(ii, new HashSet<char>());
        }
        var substringLengths = new int[s.Length];

        for (int ii = 0; ii < s.Length; ++ii)
        {
            foundChars[ii].Add(s[ii]);
            substringLengths[ii] = 1;
            for (int jj = 0; jj < ii; ++jj)
            {
                if (foundChars.ContainsKey(jj))
                {
                    if (!foundChars[jj].Contains(s[ii]))
                    {
                        substringLengths[jj] += 1;
                        foundChars[jj].Add(s[ii]);
                    }
                    else
                    {
                        foundChars.Remove(jj);
                    }
                }
            }
        }
        return substringLengths.Length == 0 ? 0 : substringLengths.Max();
    }
}