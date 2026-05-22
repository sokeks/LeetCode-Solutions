public class Solution {
    public string MergeAlternately(string word1, string word2) 
        => string.Create((word1.Length + word2.Length), (word1, word2), (buffer, state) =>
        {
            var (w1, w2) = state;
            
            var i1 = 0;
            var i2 = 0;
            var ib = 0;
            while(i1 < w1.Length && i2 < w2.Length)
            {
                buffer[ib++] = w1[i1++];
                buffer[ib++] = w2[i2++];
            }

            if (i1 < w1.Length)
            {
                w1.AsSpan(i1).CopyTo(buffer.Slice(ib));
            }
            else if (i2 < w2.Length)
            {
                w2.AsSpan(i2).CopyTo(buffer.Slice(ib));
            }
        });
}