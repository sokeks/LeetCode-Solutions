public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        if (piles.Length == 1) return (piles[0] + h - 1) / h;
        var minEatingSpeed = 1;
        var maxEatingSpeed = piles.Max();

        while (minEatingSpeed < maxEatingSpeed)
        {
            var eatingSpeed = minEatingSpeed + (maxEatingSpeed - minEatingSpeed) / 2;
            if (CanEatAllInTime(eatingSpeed, piles, h))
            {
                maxEatingSpeed = eatingSpeed;
            }
            else
            {
                minEatingSpeed = eatingSpeed + 1;
            }
        }

        return minEatingSpeed;

        static bool CanEatAllInTime(int eatingSpeed, int[] piles, long h)
        {
            var spentTime = 0L;
            foreach (var p in piles)
            {
                spentTime += (p + eatingSpeed - 1) / eatingSpeed;
                if (spentTime > h) return false;
            }

            return true;
        }
    }
}