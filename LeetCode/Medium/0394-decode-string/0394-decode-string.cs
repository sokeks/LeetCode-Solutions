public class Solution {
    public string DecodeString(string s) {
        var multipliers = new Stack<int>();
        var lengths = new Stack<int>();

        var multiplier = 0;
        var length = 0;
        var decodedString = new StringBuilder();
        var buffer = new char[1024];
        foreach (var c in s)
        {
            if (char.IsAsciiLetterLower(c))
            {
                decodedString.Append(c);
                length++;
            }
            else if (char.IsAsciiDigit(c))
            {
                multiplier *= 10;
                multiplier += c - '0';
            }
            else if (c == '[')
            {
                multipliers.Push(multiplier);
                multiplier = 0;
                lengths.Push(length);
                length = 0;
            }
            else //if  (c == ']')
            {
                if (length > buffer.Length) buffer = new char[Math.Max(length, 2 * buffer.Length)];

                decodedString.CopyTo(decodedString.Length - length, buffer, length);
                
                var previousMultiplier = multipliers.Pop();
                decodedString.EnsureCapacity(decodedString.Length + previousMultiplier * length);

                for (var i = 0; i < previousMultiplier - 1; i++)
                {
                    decodedString.Append(buffer[..length]);
                }

                length = lengths.Pop() + previousMultiplier * length;
            }
        }

        return decodedString.ToString();
    }
}