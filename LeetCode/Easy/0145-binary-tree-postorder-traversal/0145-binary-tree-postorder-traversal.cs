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
    public IList<int> PostorderTraversal(TreeNode root) {
        var values = new List<int>();
        if (root == null) return values;

        var stack = new Stack<TreeNode>();
        var current = root;
        TreeNode lastVisited = null;
        
        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            var peek = stack.Peek();
            if (peek.right != null && peek.right != lastVisited)
            {
                current = peek.right;
            }
            else
            {
                var node = stack.Pop();
                values.Add(node.val);
                lastVisited = node;
            }
        }

        return values;
    }
}