public class Solution {
    public int MaxOperations(int[] nums, int k) {
        var num2freq = new Dictionary<int, int>();

        var counter = 0;
        foreach (var n in nums)
        {
            if (n < k)
            {
                var searched = k - n;
                if (num2freq.TryGetValue(searched, out int value))
                {
                    counter++;
                    if (value > 1)
                    {
                        num2freq[searched] -= 1;
                    }
                    else
                    {
                        num2freq.Remove(searched);
                    }
                }
                else if (num2freq.TryGetValue(n, out int nValue))
                {
                    num2freq[n] = nValue + 1;
                }
                else
                {
                    num2freq[n] = 1;
                }
            }
        }
        
        return counter;
    }
}