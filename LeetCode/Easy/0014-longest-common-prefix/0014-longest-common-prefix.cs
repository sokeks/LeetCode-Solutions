public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0 || strs[0] == null)
        {
            return "";
        }
        ReadOnlySpan<char> prefix = strs[0].AsSpan();

        for (var i = 1; i < strs.Length; i++ )
        {
            if (strs[i] == null)
            {
                return "";
            }

            if (prefix.Length > strs[i].Length)
            {
                prefix = prefix.Slice(0, strs[i].Length);
            }

            var str = strs[i].AsSpan();
            while (!str.StartsWith(prefix))
            {
                prefix = prefix.Slice(0, prefix.Length - 1);
            }
            if (prefix.IsEmpty)
            {
                break;
            }
        }

        return prefix.ToString();
    }
}