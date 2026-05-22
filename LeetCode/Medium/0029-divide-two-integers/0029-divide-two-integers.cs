public class Solution {
    public int Divide(int dividend, int divisor) {
        if (dividend == int.MinValue && divisor == -1)
        {
            return int.MaxValue;
        }

        var isResultNegative = (dividend > 0) ^ (divisor > 0);
        dividend = dividend > 0 ? -dividend : dividend;
        divisor = divisor > 0 ? -divisor : divisor;

        var result = 0;
        while (dividend <= divisor)
        {
            var multiple = 1;
            var tempDivisor = divisor;
            while (tempDivisor >= (int.MinValue >> 1) && dividend <= (tempDivisor << 1))
            {
                multiple <<= 1;
                tempDivisor <<= 1;
            }
            dividend -= tempDivisor;
            result += multiple;
        }
        
        
        return isResultNegative ? -result : result;
    }
}