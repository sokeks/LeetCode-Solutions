public class Solution {
    public int MySqrt(int x) {
        long left = 0;
        long right = 50000l; // because max(x) = 2^31 -> 2 * 10^9 -> 20 * 10^8 sqrt(x) = sqrt (20 * 10^8 ) ~= 4,5... * 10^4 ~ 5 * 10^4

        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            var mul = mid * mid;

            if (mul == x)
            {
                return (int)mid;
            }
            else if (mul > x)
            {
                right = mid - 1;
            }
            else // mul < x
            {
                left = mid + 1;
            }
        }
        
        return (int)left - 1;
    }
}