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
    public int MinDepth(TreeNode root) {
        if (root == null) return 0;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var level = 1;
        
        while (queue.Count > 0)
        {
            var count = queue.Count;

            for (var i = 0; i < count; i++)
            {
                var node = queue.Dequeue();
                if (node.left == null && node.right == null)
                {
                    return level;
                }
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            level++;
        }

        throw new InvalidOperationException("Tree is malformed or ciricular");
    }
}