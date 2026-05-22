public class Solution {
    public int MaxVowels(string s, int k) {
        var currentVowels = 0;
        for (var i = 0; i < k; i++)
        {
            if (IsVowel(s[i])) currentVowels++;
        }

        var maxVowels = currentVowels;
        for (var i = k; i < s.Length; i++)
        {
            if (currentVowels == k) return currentVowels;

            if (IsVowel(s[i - k])) currentVowels--;
            if (IsVowel(s[i])) currentVowels++;

            if (currentVowels > maxVowels) maxVowels = currentVowels;
        }
        
        return maxVowels;

        bool IsVowel(char c)
        {
            var vowelMask = (1 << 0) | (1 << 4) | (1 << 8) | (1 << 14) | (1 << 20);
            return (vowelMask & (1 << (c - 'a'))) != 0;
        }
    }
}