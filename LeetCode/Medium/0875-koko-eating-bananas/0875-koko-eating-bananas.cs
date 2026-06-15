public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        if (piles.Length == 1) return (int)Math.Ceiling((double)piles[0] / h);
        var pilesSum = Sum(piles);
        var minEatingSpeed = 1;
        var maxEatingSpeedLong = (pilesSum - (piles.Length - 1)) / (h - (piles.Length - 1))
            + (((pilesSum - (piles.Length - 1)) % (h - (piles.Length - 1))) == 0 ? 0 : 1);
        var maxEatingSpeed = (int)Math.Min(maxEatingSpeedLong, int.MaxValue);

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
        static long Sum(int[] arr)
        {
            var sum = 0L;
            foreach(var a in arr) sum += a;
            return sum;
        }

        static bool CanEatAllInTime(int eatingSpeed, int[] piles, int h)
        {
            var spentTime = 0;
            foreach (var p in piles)
            {
                spentTime += ((p / eatingSpeed) + ((p % eatingSpeed) == 0 ? 0 : 1));
                if (spentTime > h) return false;
            }

            return true;
        }
    }
}