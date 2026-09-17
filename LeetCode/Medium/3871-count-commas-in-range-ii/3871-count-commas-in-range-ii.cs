public class Solution {
    public long CountCommas(long n) {
        long commasCount = 0;
        long threshold = 1000;

        while (threshold <= n)
        {
            commasCount += n - threshold + 1;
            threshold *= 1000;
        }
        
        return commasCount;
    }
}