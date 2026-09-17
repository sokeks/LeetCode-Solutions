class Solution {
public:
    long long countCommas(long long n) {
        long long commasCount = 0;
        long long threshold = 1000;

        while (n >= threshold)
        {
            commasCount += n - threshold + 1;
            threshold *= 1000;
        }
        
        return commasCount;
    }
};