public class Solution {
    private const int AlphabetNumericalSystemBase = 26;
    private static readonly int MaxCharsNumForInt = (int)Math.Log(int.MaxValue, AlphabetNumericalSystemBase) + 1;
    public string ConvertToTitle(int columnNumber) {
        Span<char> buffer = stackalloc char[MaxCharsNumForInt];
        var pos = buffer.Length;
        while (columnNumber > 0)
        {
            columnNumber--; // mapping from A->1-based to A->0-based

            pos--;
            buffer[pos] = (char)('A' + columnNumber % AlphabetNumericalSystemBase);

            columnNumber /= AlphabetNumericalSystemBase;
        }

        return new string(buffer[pos..]);
    }
}