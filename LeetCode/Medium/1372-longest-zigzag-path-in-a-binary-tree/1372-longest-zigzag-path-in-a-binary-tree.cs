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
    // *** recommended solution - 1 less ternary operation to be done, but much bigger cognitive load - I would stay with mine ***
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
                var zigZagCountToRight = zigZagCountIfComesFromLeft + 1;
                maxZigZagCount = Math.Max(zigZagCountToRight, maxZigZagCount);
                stack.Push((node.right, 0, zigZagCountToRight));
            }
            if (node.left != null)
            {
                var zigZagCountToLeft = zigZagCountIfComesFromRight + 1;
                maxZigZagCount = Math.Max(zigZagCountToLeft, maxZigZagCount);
                stack.Push((node.left, zigZagCountToLeft, 0));
            }
        }

        return maxZigZagCount;
    }



    // *** my first solution - 1 more ternary operation to be done, but much less cognitive load ***
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