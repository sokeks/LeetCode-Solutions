public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        var gcd = GetGcd(str1.Length, str2.Length);

        for (var i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str1[i % gcd]) return "";
        }

        for (var i = 0; i < str2.Length; i++)
        {
            if (str2[i] != str1[i % gcd]) return "";
        }

        return str1[..gcd];

        int GetGcd(int a, int b)
        {
            while (b != 0)
            {
                (a, b) = (b, a % b);
            }
            return a;
        }
    }
}