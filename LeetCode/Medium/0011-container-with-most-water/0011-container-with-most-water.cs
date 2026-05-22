public class Solution {
    public int MaxArea(int[] height) {
        var left = 0;
        var right = height.Length - 1;
        var maxArea = 0;

        while (left < right)
        {
            var heightLeft = height[left];
            var heightRight = height[right];
            var newArea = (right - left) * (heightLeft > heightRight ? heightRight : heightLeft);
            maxArea = Math.Max(newArea, maxArea);
            if (heightLeft > heightRight)
            {
                --right;
            }
            else
            {
                ++left;
            }
        }
        
        return maxArea;
    }
}