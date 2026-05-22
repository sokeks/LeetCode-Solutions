public class Solution {
    // answer for follow-up: I would create precalculated inverted[256]
    // public int ReverseBits(int n) {
    //     var input = (uint)n;
    //     var output = 0u;
    //     for (var i = 0; i < 32; i++)
    //     {
    //         output = output << 1 | (input & 1);
    //         input >>= 1;
    //     }

    //     return (int)output;
    // }

    public int ReverseBits(int n) {
        var input = (uint)n;
        input = (input & 0xFFFF0000) >> 16 | (input & 0x0000FFFF) << 16;
        input = (input & 0xFF00FF00) >> 8 | (input & 0x00FF00FF) << 8;
        input = (input & 0xF0F0F0F0) >> 4 | (input & 0x0F0F0F0F) << 4;
        input = (input & 0xCCCCCCCC) >> 2 | (input & 0x33333333) << 2;
        input = (input & 0xAAAAAAAA) >> 1 | (input & 0x55555555) << 1;

        return (int)input;
    }
}