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
    private const int MaxNodes = 100;
    public IList<int> InorderTraversal(TreeNode root) {
        var values = new List<int>(MaxNodes);
        var stack = new Stack<TreeNode>(MaxNodes / 10);
        var current = root;

        while (current != null || stack.Count != 0)
        {
            if (current != null)
            {
                stack.Push(current);
                current = current.left;
            }
            else
            {
                current = stack.Pop();
                values.Add(current.val);
                current = current.right;
            }
        }

        return values;
    }
}