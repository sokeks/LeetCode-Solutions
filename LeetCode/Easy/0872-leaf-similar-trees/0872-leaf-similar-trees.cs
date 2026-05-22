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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        var stack1 = new Stack<TreeNode>();
        var stack2 = new Stack<TreeNode>();

        stack1.Push(root1);
        stack2.Push(root2);

        while (stack1.Count > 0 && stack2.Count > 0)
        {
            var leaf1 = GetNextLeaf(stack1);
            var leaf2 = GetNextLeaf(stack2);

            if (leaf1 != null && leaf2 != null && leaf1.val != leaf2.val) return false;
        }
        
        return stack1.Count == 0 && stack2.Count == 0;
        
        static TreeNode GetNextLeaf(Stack<TreeNode> stack)
        {
            while (stack.Count > 0)
            {
                var node = stack.Pop();

                if (node.right == null && node.left == null)
                {
                    return node;
                }
                
                if (node.right != null) stack.Push(node.right);
                if (node.left != null) stack.Push(node.left);
            }

            return null;
        }
    }
}