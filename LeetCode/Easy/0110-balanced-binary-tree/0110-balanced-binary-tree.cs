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
    public bool IsBalanced(TreeNode root) {
        if (root == null) return true;

        var stack = new Stack<TreeNode>();
        var heights = new Stack<int>();
        var current = root;
        var lastVisited = (TreeNode)null;

        while (current != null || stack.Count > 0)
        {
            if (current != null)
            {
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
                    var node = stack.Pop();
                    lastVisited = node;

                    var rHeight = node.right == null
                        ? 0
                        : heights.Pop();
                    var lHeight = node.left == null
                        ? 0
                        : heights.Pop();
                    if (Math.Abs(lHeight - rHeight) > 1 )
                    {
                        return false;
                    }
                    heights.Push(Math.Max(lHeight, rHeight) + 1);
                }
            }
        }
        
        return true;
    }
}