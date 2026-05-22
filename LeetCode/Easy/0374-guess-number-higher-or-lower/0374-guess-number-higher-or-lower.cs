/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        var left = 1;
        var right = n;

        while (left <= right)
        {
            var mid = left + ((right - left) >>> 1); // >>> 1 === /2, but for sure cheaper, if compiler fails to optimize it

            switch (guess(mid))
            {
                case -1:
                    right = mid - 1;
                    break;
                case 1:
                    left = mid + 1;
                    break;
                case 0:
                    return mid;
                default:
                    throw new System.Diagnostics.UnreachableException("API Contract violation: guess() returned invalid state.");
            }
        }
        
        throw new System.Diagnostics.UnreachableException("Seriously incorrect logic.");
    }
}