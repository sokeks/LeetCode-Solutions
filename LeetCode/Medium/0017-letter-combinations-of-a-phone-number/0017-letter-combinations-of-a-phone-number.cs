public class Solution {
    public IList<string> LetterCombinations(string digits) {
        string[] keyMap = new string[] { "", "",  "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        var combinations = new string[CalculateTotalCombinations(digits, keyMap)];
        
        var last = digits.Length - 1;
        var stack = new Stack<(char letter, int position)>();
        foreach (var c in keyMap[digits[0] - '0']) stack.Push((c, 0));

        var sb = new StringBuilder(digits.Length);
        var combinationsCount = 0;
        while (stack.Count > 0)
        {
            var (letter, position) = stack.Pop();
            sb.Length = position;
            sb.Append(letter);
            if (position == last) combinations[combinationsCount++] = sb.ToString();
            else foreach (var c in keyMap[digits[position + 1] - '0']) stack.Push((c, position + 1));
        }

        return combinations;
        static int CalculateTotalCombinations(string digits, string[] keyMap)
        {
            var length = 1;
            foreach (var d in digits) length *= keyMap[d - '0'].Length;

            return length;
        } 
    }

    // --- recursive option, simpler to write (and to invent), but is not a bullet-proof for a very long input --
    public IList<string> LetterCombinationsRec(string digits) {
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