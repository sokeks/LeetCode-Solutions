public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        var successfulPairsCount = spells.Length < 1024 ? stackalloc int[spells.Length] : new int[spells.Length];

        var potionsSorted = potions.Length < 1024 ? stackalloc int[potions.Length] : new int[potions.Length];
        potions.AsSpan().CopyTo(potionsSorted);
        potionsSorted.Sort();

        for (var i = 0; i < spells.Length; i++)
        {
            long spell = spells[i];
            var left = 0;
            var right = potions.Length;
            while (left < right)
            {
                var mid = left + (right - left) / 2;
                // Console.WriteLine($"{i}:{left} {mid} {right}");
                if (potionsSorted[mid] * spell >= success)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            successfulPairsCount[i] = potions.Length - left;
        }

        return successfulPairsCount.ToArray();
    }
}