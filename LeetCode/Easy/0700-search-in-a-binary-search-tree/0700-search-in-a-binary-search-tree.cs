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
    public TreeNode SearchBST(TreeNode root, int val) {
        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            if (current.val == val)
            {
                return current;
            }

            if (current.val < val && current.right != null) stack.Push(current.right);
            if (current.val > val && current.left != null) stack.Push(current.left);
        }

        return null;
    }
}