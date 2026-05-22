public class Solution {
    public string ReverseVowels(string s)
        => string.Create(s.Length, s, (span, input) =>
            {
                input.AsSpan().CopyTo(span);

                var left = 0;
                var right = input.Length - 1;

                while (left < right)
                {
                    while (left < right && !IsVowel(span[left])) left++;
                    while (left < right && !IsVowel(span[right])) right--;

                    if (left == right) return;

                    var tmp = span[left];
                    span[left] = span[right];
                    span[right] = tmp;
                    left++;
                    right--;
                    
                }
            }
        );
    
    private bool IsVowel(char c)
    => c switch
        {
            'a' or 'e' or 'i' or 'o' or 'u' or 'A'or 'E' or 'I' or 'O' or 'U' => true,
            _ => false
        };
}