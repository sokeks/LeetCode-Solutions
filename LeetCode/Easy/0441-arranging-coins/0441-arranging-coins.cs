public class Solution {
    // it's arithmetic sequence from a_1 = 1 and r = 1, so we solve an equatio of a_n^2 + a_n - 2n <= 0
    public int ArrangeCoins(int n) {
        var delta = 1 + 8L * n; // delta = b^2 - 4ac -> 1^2 - 4 * 1 * (-2n) = 1 + 8n
        return (int)Math.Floor((-1 + Math.Sqrt(delta)) / 2);
    }
}