public class Solution {
    public string AddBinary(string a, string b) {
        var (longer, shorter) = a.Length > b.Length ? (a, b) : (b, a);
        Span<char> result = stackalloc char[longer.Length + 1]; // max 20kB

        var carry = 0;
        var s = shorter.Length - 1;
        var l = longer.Length - 1;
        var r = result.Length - 1;

        while (l >= 0) // shorter will end up faster
        {
            var sum = carry;
            sum += s >= 0 ? shorter[s] - '0' : 0;
            sum += longer[l] - '0';

            result[r] = (char)((sum % 2) + '0');
            carry = sum / 2;

            s--;
            l--;
            r--;
        }

        if (carry == 1)
        {
            result[0] = '1';
            return new string(result.Slice(0));
        }
        else
        {
            return new string(result.Slice(1));
        }
    }


}