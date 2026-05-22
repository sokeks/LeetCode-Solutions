public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if (n == 0) return true;
        var i = 0;
        while (i < flowerbed.Length)
        {
            if ((i != flowerbed.Length - 1) && flowerbed[i + 1] == 1)
            {
                i += 3;
            }
            else if (flowerbed[i] == 1)
            {
                i += 2;
            }
            else
            {
                n--;
                if (n == 0) return true;
                i += 2;
            }
        }
        
        return false;
    }
}