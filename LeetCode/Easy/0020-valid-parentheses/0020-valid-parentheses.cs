public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 == 1)
        {
            return false;
        }

        var stack = new Stack<char>(s.Length);
        for (var i = 0; i < s.Length; i++)
        {
            var current = s[i];
            if (IsOpeningParentheses(current))
            {
                stack.Push(current);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                var open = stack.Pop();
                if (!Matches(open, current))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    // [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsOpeningParentheses(char c)
        => c == '(' || c == '{' || c == '[';

    // [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool Matches(char open, char close)
        => (open == '(' && close == ')') || 
            (open == '[' && close == ']') ||
            (open == '{' && close == '}');
}