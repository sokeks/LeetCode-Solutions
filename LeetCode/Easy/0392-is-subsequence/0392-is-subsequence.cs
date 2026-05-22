public class Solution {
    // multi s solution (in target version it should have string[] s or sth similar)
    //
    // for the comibinedIndicesT I use the jagged array for simplicity in this example,
    // however in production code, I'd create ref struct with span of all indices of all
    // letters of t string and span of start indices, and the ref struct would have a function
    // to return span of all indices for a given letter.
    private const int EnglishAlphabetSize = 26;
    public bool IsSubsequence(string s, string t) {
        var combinedIndicesT = CombineIndices(t);
        var lastIndexT = -1;
        Span<int> idxs = stackalloc int[EnglishAlphabetSize];

        foreach (var c in s)
        {
            while (idxs[c - 'a'] < combinedIndicesT[c - 'a'].Length && combinedIndicesT[c - 'a'][idxs[c - 'a']] < lastIndexT) // to use BianrySearch
            {
                idxs[c - 'a']++;
            }

            // Console.WriteLine($"c={c} idxs[c - 'a']={idxs[c - 'a']}");

            if (idxs[c - 'a'] == combinedIndicesT[c - 'a'].Length)
            {
                return false;
            }

            lastIndexT = combinedIndicesT[c - 'a'][idxs[c - 'a']];
            idxs[c - 'a']++;
            Console.WriteLine($"lastIndexT={lastIndexT}");

        }

        return true;
    }

    private int[][] CombineIndices(string t)
    {
        Span<int> frequencies = stackalloc int[EnglishAlphabetSize];
        var ts = t.AsSpan();
        foreach (var c in ts)
        {
            frequencies[c - 'a']++;
        }

        var combinedIndices = new int[EnglishAlphabetSize][];
        for (var i = 0; i < combinedIndices.Length; i++)
        {
            combinedIndices[i] = new int[frequencies[i]];
        }

        Span<int> idxs = stackalloc int[EnglishAlphabetSize];
        for (var i = 0; i < ts.Length; i++)
        {
            combinedIndices[ts[i] - 'a'][idxs[ts[i] - 'a']++] = i;
        }

        return combinedIndices;
    }

    // classical solution
    // public bool IsSubsequence(string s, string t) {
    //     var ss = s.AsSpan();
    //     var ts = t.AsSpan();

    //     var sp = 0;
    //     var tp = 0;
    //     while (sp < ss.Length && tp < ts.Length)
    //     {
    //         if (ss[sp] == ts[tp]) sp++;
    //         tp++;
    //     }

    //     return sp == ss.Length;
    // }

    // I don't understand exactly the follow up question - what's the issue?
}