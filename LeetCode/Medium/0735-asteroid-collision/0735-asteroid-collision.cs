public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var length = asteroids.Length;
        Span<int> survived = length <= 1024 ? stackalloc int[length] : new int[length];
        var lastSurvivedIdx = -1;

        foreach (var asteroid in asteroids)
        {
            var asteroidSurvived = true;
            while (asteroidSurvived && asteroid < 0 && lastSurvivedIdx >= 0 && survived[lastSurvivedIdx] > 0)
            {
                asteroidSurvived = survived[lastSurvivedIdx] < -asteroid;

                if (survived[lastSurvivedIdx] <= -asteroid) lastSurvivedIdx--;
            }

            if (asteroidSurvived) survived[++lastSurvivedIdx] = asteroid;
        }

        return lastSurvivedIdx == -1 ? Array.Empty<int>() : survived[..(lastSurvivedIdx + 1)].ToArray();
    }
}