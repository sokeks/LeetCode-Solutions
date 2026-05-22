public class Solution {
    public bool IsHappy(int n) {
        var slow = n;
        var fast = GetNext(n);
        while (fast != 1 && fast != slow)
        {
            fast = GetNext(GetNext(fast));
            slow = GetNext(slow);
        }

        return fast == 1;
    }

    private int GetNext(int n)
    {
        var squareSum = 0;
        while (n > 0)
        {
            var digit = (n % 10);
            squareSum += digit * digit;
            n /= 10;
        }
        return squareSum;
    }
}