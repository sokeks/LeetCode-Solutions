public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        var potionsSorted = potions.Length < 1024 ? stackalloc int[potions.Length] : new int[potions.Length];
        potions.AsSpan().CopyTo(potionsSorted);
        potionsSorted.Sort();

        var pairsCount = new int[spells.Length];

        for (var i = 0; i < spells.Length; i++)
        {
            var left = 0;
            var right = potionsSorted.Length;
            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if ((long)potionsSorted[mid] * spells[i] >= success)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            pairsCount[i] = potionsSorted.Length - left;
        }

        return pairsCount;
    }
}