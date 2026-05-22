public class Solution {
    public string LongestPalindrome(string s) { // s = "cbbd", s.Length = 4, s[0] = 'c', s[1] = 'b', s[2] = 'b', s[3] = 'd' 
        var maxLengthStart = 0;
        var maxLengthEnd = 0;
        
        var currentLengthStart = 0;
        var currentLengthEnd = 0;

        for (var ii = 0; ii < 5; ++ii)
        {
            Console.WriteLine(" ii = " + ii);
        }
        
        for (var ii = 0; ii < (s.Length - 1); ++ii)
        {
            for (var jj = 0; (ii - jj) >= 0 && (ii + 1 + jj) < s.Length; ++jj) 
            {
                if (s[ii - jj] == s[ii + 1 + jj])
                {
                    currentLengthStart = ii - jj;
                    currentLengthEnd = ii + 1 + jj;
                }
                else
                {
                    break;
                }
            }
            if (currentLengthEnd + 1 - currentLengthStart > maxLengthEnd - maxLengthStart)
            {
                maxLengthStart = currentLengthStart;
                maxLengthEnd = currentLengthEnd;
            }
        }

        for (var ii = 0; ii < (s.Length - 2); ++ii)
        {
            for (var jj = 0; (ii - jj) >= 0 && (ii + 2 + jj) < s.Length; ++jj)
            {
                if (s[ii - jj] == s[ii + 2 + jj]) 
                {
                    currentLengthStart = ii - jj;
                    currentLengthEnd = ii + 2 + jj;
                }
                else
                {
                    break;
                }
            }
            if (currentLengthEnd + 1 - currentLengthStart > maxLengthEnd - maxLengthStart)
            {
                maxLengthStart = currentLengthStart;
                maxLengthEnd = currentLengthEnd;
            }
        }

        return s[maxLengthStart..(maxLengthEnd + 1)];
    }
}