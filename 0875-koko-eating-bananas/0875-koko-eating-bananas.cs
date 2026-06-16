public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
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
                spentTime += CeilDivide(p, eatingSpeed);
                if (spentTime > h) return false;
            }

            return true;
        }

        static long CeilDivide(long a, long b)
            => (a + b - 1) / b;
    }
}