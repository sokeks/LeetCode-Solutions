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
    private const int MaxNodes = 1000;
    public bool IsSymmetric(TreeNode root) {
        var stack = new Stack<(TreeNode, TreeNode)>(MaxNodes / 2);

        stack.Push((root.left, root.right));
        
        while (stack.Count > 0)
        {
            var (lNode, rNode) = stack.Pop();

            if (lNode == null && rNode == null) continue;   // symmetry - continue
            if (lNode == null || rNode == null || lNode.val != rNode.val) return false; // tree or value asymmetry 
            
            stack.Push((lNode.left, rNode.right));
            stack.Push((lNode.right, rNode.left));
        }

        return true;
    }
}