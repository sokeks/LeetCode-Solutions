public class Solution {
    public int MyAtoi(string s) {
        var current = 0;
        
        // remove leading spaces
        while (current < s.Length && s[current] == ' ')
        {
            ++current;
        }

        var isPositive = true;
        if (current < s.Length && s[current] == '-')
        {
            isPositive = false;
            ++current;
        }
        else if (current < s.Length && s[current] == '+')
        {
            ++current;
        }

        var result = 0;
        const int maxIntBy10 = int.MaxValue / 10;
        const int maxIntLsd = int.MaxValue % 10;
        const int minIntBy10 = int.MinValue / 10;
        const int minIntLsd = int.MinValue % 10;
        while (current < s.Length && s[current] <= '9' && s[current] >= '0')
        {
            int digit = (s[current] - '0') * (isPositive ? 1 : -1);
            
            var willOverflowPositive = isPositive && (result > maxIntBy10 || result == maxIntBy10 && digit > maxIntLsd); 
            if (willOverflowPositive)
            {
                return int.MaxValue;
            }
            
            var willOverflowNegative = !isPositive && (result < minIntBy10 || result == minIntBy10 && digit < minIntLsd);
            if (willOverflowNegative)
            {
                return int.MinValue;
            }

            result = result * 10 + digit;

            ++current;
        }

        return result; 

    }
}