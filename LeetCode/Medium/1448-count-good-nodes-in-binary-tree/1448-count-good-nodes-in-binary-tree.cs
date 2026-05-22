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
    public int GoodNodes(TreeNode root) {
        const int reasonableStartStackSize = 32;
        var stack = new Stack<(TreeNode node, int max)>(reasonableStartStackSize);
        var goodCount = 1;
        if (root.right != null) stack.Push((root.right, root.val));
        if (root.left != null) stack.Push((root.left, root.val));

        while (stack.Count > 0)
        {
            var (node, max) = stack.Pop();
            if (node.val >= max)
            {
                goodCount++;
                if (node.val > max) max = node.val;
            }

            if (node.right != null) stack.Push((node.right, max));
            if (node.left != null) stack.Push((node.left, max));
        }

        return goodCount;
    }
}