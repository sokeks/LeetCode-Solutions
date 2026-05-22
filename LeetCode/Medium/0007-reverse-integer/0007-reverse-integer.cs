public class Solution {
    public int Reverse(int x) {
        int result = 0;
        while (x != 0)
        {
            var pop = x % 10;
            var willOverflowPositive = result > Int32.MaxValue / 10 || (result == Int32.MaxValue / 10 && pop > Int32.MaxValue % 10);
            var willOveflowNegative = result < Int32.MinValue / 10 || (result == Int32.MinValue / 10 && pop < Int32.MinValue % 10); 
            if (willOverflowPositive || willOveflowNegative)
            {
                return 0;
            }
            result = result * 10 + pop;
            x /= 10;
        }

        return result;
    }
}