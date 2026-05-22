public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var results = new List<string>();
        GenerateParenthesis(n, 0, 0, 0, new char[2 * n], results);
        return results;
    }

    private void GenerateParenthesis(int n, int opened, int closed, int idx, char[] result, IList<string> results)
    {
        if (idx >= 2 * n)
        {
            results.Add(new string(result));
            return;
        }

        if (opened < n)
        {
            result[idx] = '(';
            GenerateParenthesis(n, opened + 1, closed, idx + 1, result, results);
        }
        if (opened > closed)
        {
            result[idx] = ')';
            GenerateParenthesis(n, opened, closed + 1, idx + 1, result, results);
        }
    }
}