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
    public bool HasPathSum(TreeNode root, int targetSum) {
        if (root == null) return false;
        var stack = new Stack<TreeNode>();
        TreeNode lastVisited = null;
        var current = root;
        var sum = 0;

        while (current != null || stack.Count > 0)
        {
            if (current != null)
            {
                sum += current.val;
                if (current.left == null && current.right == null && sum == targetSum)
                {
                    return true;
                }
                stack.Push(current);
                current = current.left;
            }
            else
            {
                var peek = stack.Peek();
                if (peek.right != null && peek.right != lastVisited)
                {
                    current = peek.right;
                }
                else
                {
                    stack.Pop();
                    lastVisited = peek;
                    sum -= peek.val;
                }
            }

        }

        return false;
    }
}