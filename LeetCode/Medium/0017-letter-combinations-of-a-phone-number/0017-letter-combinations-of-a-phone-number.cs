public class Solution {
    public IList<string> LetterCombinations(string digits) {
        
        var combinations = new string[CalculateTotalCombinations(digits)];
        
        var last = digits.Length - 1;
        var stack = new Stack<(char letter, int position)>();
        foreach (var c in GetLettersFor(digits[0])) stack.Push((c, 0));

        var buffer = digits.Length < 1024 ? stackalloc char[digits.Length] : new char[digits.Length];
        var combinationsCount = 0;
        while (stack.Count > 0)
        {
            var (letter, position) = stack.Pop();
            buffer[position] = letter;
            if (position == last) combinations[combinationsCount++] = new string(buffer);
            else foreach (var c in GetLettersFor(digits[position + 1])) stack.Push((c, position + 1));
        }

        return combinations;
        static int CalculateTotalCombinations(string digits)
        {
            var length = 1;
            foreach (var d in digits) length *= GetLettersFor(d).Length;

            return length;
        }

        static string GetLettersFor(char digit)
        {
            string[] keyMap = new string[] { "", "",  "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            return keyMap[digit - '0'];
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