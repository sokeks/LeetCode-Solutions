public class Solution {
    public bool IsPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsAsciiLetterOrDigit(s[left]))
            {
                left++;
            }

            while (left < right && !char.IsAsciiLetterOrDigit(s[right]))
            {
                right--;
            }

            // only for this code, but unmaintanable for sudden need of UTF-8
            var lChar = (s[left] >= 'A' && s[left] <= 'Z')
                ? s[left] | 32
                : s[left];

            // only for this code, but unmaintanable for sudden need of UTF-8
            var rChar = (s[right] >= 'A' && s[right] <= 'Z')
                ? s[right] | 32
                : s[right];

            if (lChar != rChar)
            {
                return false;
            }
            left++;
            right--;
        }
        
        return true;
    }
}