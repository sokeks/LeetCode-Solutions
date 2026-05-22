public class Solution {
    public IList<string> LetterCombinations(string digits) {
        var results = new List<string>();
        LetterCombinations(digits, 0, new StringBuilder(), results);
        return results;
    }

    public void LetterCombinations(string digits, int idx, StringBuilder sb, IList<string> results) {
        if (idx >= digits.Length)
        {
            results.Add(sb.ToString());
        }
        else
        {
            foreach (var c in GetChars(digits[idx]))
            {
                LetterCombinations(digits, idx + 1, sb.Append(c) , results);
                sb.Length--;
            } 
        }
    }

    private string GetChars(char digit)
    {
        return digit switch {
            '2' => "abc",
            '3' => "def",
            '4' => "ghi",
            '5' => "jkl",
            '6' => "mno",
            '7' => "pqrs",
            '8' => "tuv",
            '9' => "wxyz",
            _ => ""
        };
    }
}