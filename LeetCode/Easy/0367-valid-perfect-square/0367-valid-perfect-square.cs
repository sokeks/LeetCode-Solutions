public class Solution {
    public bool IsPerfectSquare(int num) {
        var left = 1;
        var right = num;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            var product = (long)mid * mid;

            if (product == num)
            {
                return true;
            }
            else if (product < num)
            {
                left = mid + 1;
            }
            else // product > num
            {
                right = mid - 1;
            }
        }
        
        return false;
    }
}