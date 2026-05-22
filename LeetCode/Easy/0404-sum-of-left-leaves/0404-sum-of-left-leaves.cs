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
    public int SumOfLeftLeaves(TreeNode root) {
        bool IsLeftLeaf(TreeNode current) => current.left.left == null && current.left.right == null;
        var sum = 0;
        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            if (current.right != null) stack.Push(current.right);
            if (current.left != null)
            {
                if (IsLeftLeaf(current))
                {
                    sum += current.left.val;
                }
                else
                {
                    stack.Push(current.left);
                }
            }   
        }

        return sum;
    }
}