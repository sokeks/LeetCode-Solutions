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
    enum Directions
    {
        none,
        left,
        right
    }

    public int LongestZigZag(TreeNode root) {
        var stack = new Stack<(TreeNode node, int zigZagCount, Directions dir)>();
        stack.Push((root, 0, Directions.none));

        var maxZigZagCount = 0;
        while (stack.Count > 0)
        {
            var (node, zigZagCount, dir) = stack.Pop();

            maxZigZagCount = Math.Max(zigZagCount, maxZigZagCount);

            if (node.right != null) stack.Push((node.right, dir == Directions.left ? zigZagCount + 1 : 1, Directions.right));
            if (node.left != null) stack.Push((node.left, dir == Directions.right ? zigZagCount + 1 : 1, Directions.left));
        }

        return maxZigZagCount;
    }
}