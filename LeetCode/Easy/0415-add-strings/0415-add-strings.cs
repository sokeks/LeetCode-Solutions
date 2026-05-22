public class Solution {
    public string AddStrings(string num1, string num2) {
        var resultLength = Math.Max(num1.Length, num2.Length) + 1;
        Span<char> result = stackalloc char[resultLength];

        var carry = 0;
        var i1 = num1.Length - 1;
        var i2 = num2.Length - 1;
        var ir = resultLength - 1;
        while (i1 >= 0 && i2 >= 0)
        {
            var value = (num1[i1--] - '0') + (num2[i2--] - '0') + carry;
            result[ir--] = (char)((value >= 10 ? value - 10 : value)  + '0');
            carry = value >= 10 ? 1 : 0;
        }

        var (i, num) = i1 > i2 ? (i1, num1) : (i2, num2);
        while (i >= 0 && carry != 0)
        {
            var value = (num[i--] - '0') + carry;
            result[ir--] = (char)((value >= 10 ? value - 10 : value)  + '0');
            carry = value >= 10 ? 1 : 0;
        }

        while (i >= 0)
        {
            result[ir--] = num[i--];
        }

        if (carry == 1) result[0] = '1'; 
        
        return new string(result[(1 - carry)..]);
    }
}