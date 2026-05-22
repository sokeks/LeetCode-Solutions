public class Solution {
    public int[] CountBits(int n) {
        var ones = new int[n + 1];
        for (var i = 1; i <= n; i++)
        {
            ones[i] = ones[i >> 1] + (i & 1); // "i >> 1" === "i / 2" ; "i & 1" === "i % 2"
        }

        return ones;
    }
}

// classic solution
// public class Solution {
//     public int[] CountBits(int n) {
//         var ones = new int[n + 1];
//         for (var i = 0; i <= n; i++)
//         {
//             var count = 0;
//             var ii = i;
//             while (ii != 0)
//             {
//                 ii &= (ii - 1);
//                 count++;
//             }
//             ones[i] = count;
//         }

//         return ones;
//     }
// }