public class Solution {
    public int CountSegments(string s) {
        if (s.Length == 0) return 0;

        var counter = s[0] != ' ' ? 1 : 0;
        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] != ' ' && s[i - 1] == ' ') counter++;
        }

        return counter;
    }
}