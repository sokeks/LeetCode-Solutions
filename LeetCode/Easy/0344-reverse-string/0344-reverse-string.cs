public class Solution {
    public void ReverseString(char[] s) {
        var left = 0;
        var right = s.Length - 1;
        while (left < right)
        {
            // could use tuple swap, however it could be slightly slower
            var tmp = s[left];
            s[left] = s[right];
            s[right] = tmp;

            left++;
            right--;
        }
    }
}