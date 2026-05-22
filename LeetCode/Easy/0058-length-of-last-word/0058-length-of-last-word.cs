public class Solution {
    public int LengthOfLastWord(string s) {
        var i = s.Length - 1;

        while (i >= 0 && s[i] == ' ') i--;

        var lastWordLength = 0;
        while (i >= 0 && s[i] != ' ')
        {
            lastWordLength++;
            i--;
        }

        return lastWordLength;
    }
}