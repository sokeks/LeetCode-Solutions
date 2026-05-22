public class Solution {
    public bool CloseStrings(string word1, string word2) {
        if (word1.Length != word2.Length) return false;

        const int englishAlphabetSize = 26;
        Span<int> occurrences1 = stackalloc int[englishAlphabetSize];
        Span<int> occurrences2 = stackalloc int[englishAlphabetSize];
        var occurredCharsBitMask1 = AnalyzeWord(word1, occurrences1);
        var occurredCharsBitMask2 = AnalyzeWord(word2, occurrences2);

        if (occurredCharsBitMask1 != occurredCharsBitMask2) return false;

        occurrences1.Sort();
        occurrences2.Sort();
        
        return occurrences1.SequenceEqual(occurrences2);

        static int AnalyzeWord(string word, Span<int> occurrences)
        {
            var occurredCharsBitMask = 0;
            foreach (var c in word)
            {
                var charIndex = c - 'a';
                occurredCharsBitMask |= (1 << charIndex);
                occurrences[charIndex]++;
            }

            return occurredCharsBitMask;
        }
    }
}