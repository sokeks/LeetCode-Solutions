/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int LongestZigZag(TreeNode root) {
        const int reasonableStartStackSize = 32;
        var stack = new Stack<(TreeNode node, int zigZagCountIfComesFromLeft, int zigZagCountIfComesFromRight)>(reasonableStartStackSize);
        stack.Push((root, 0, 0));

        var maxZigZagCount = 0;
        while (stack.Count > 0)
        {
            var (node, zigZagCountIfComesFromLeft, zigZagCountIfComesFromRight) = stack.Pop();

            if (node.right != null)
            {
                var zigZacCountToRight = zigZagCountIfComesFromLeft + 1;
                maxZigZagCount = Math.Max(zigZacCountToRight, maxZigZagCount);
                stack.Push((node.right, 0, zigZacCountToRight));
            }
            if (node.left != null)
            {
                var zigZacCountToLeft = zigZagCountIfComesFromRight + 1;
                maxZigZagCount = Math.Max(zigZacCountToLeft, maxZigZagCount);
                stack.Push((node.left, zigZacCountToLeft, 0));
            }
        }

        return maxZigZagCount;
    }



    // *** my first solution ***
    // enum Directions
    // {
    //     none,
    //     left,
    //     right
    // }

    // public int LongestZigZag(TreeNode root) {
    //     const int reasonableStartStackSize = 32;
    //     var stack = new Stack<(TreeNode node, int zigZagCount, Directions dir)>(reasonableStartStackSize);
    //     stack.Push((root, 0, Directions.none));

    //     var maxZigZagCount = 0;
    //     while (stack.Count > 0)
    //     {
    //         var (node, zigZagCount, dir) = stack.Pop();

    //         maxZigZagCount = Math.Max(zigZagCount, maxZigZagCount);

    //         if (node.right != null) stack.Push((node.right, dir == Directions.left ? zigZagCount + 1 : 1, Directions.right));
    //         if (node.left != null) stack.Push((node.left, dir == Directions.right ? zigZagCount + 1 : 1, Directions.left));
    //     }

    //     return maxZigZagCount;
    // }
}