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
    public TreeNode DeleteNode(TreeNode root, int key) {
        var sentinel = new TreeNode(int.MinValue, root, null);

        var (deleteNode, previous) = FindDeleteNode(root, sentinel, key);
        if (deleteNode == null) return root;

        // Console.WriteLine($"Found: {deleteNode.val}, {previous.val}");

        if (deleteNode.left == null)
        {
            if (previous.left == deleteNode) previous.left = deleteNode.right;
            else previous.right = deleteNode.right;
        }
        else
        {
            if (previous.left == deleteNode) previous.left = deleteNode.left;
            else previous.right = deleteNode.left;

            // previous.left = deleteNode.left;

            var rightest = deleteNode.left;
            while (rightest.right != null) rightest = rightest.right;
            rightest.right = deleteNode.right;

            deleteNode.left = null;
        }

        deleteNode.right = null;

        return sentinel.left;
        static (TreeNode, TreeNode) FindDeleteNode(TreeNode current, TreeNode previous, int key)
        {
            while (current != null)
            {
                // Console.WriteLine($"Loop: {current.val}, {previous.val}");
                if (current.val == key) return (current, previous);
                
                previous = current;
                if (current.val > key) current = current.left;
                else current = current.right;
                

            }

            return (null, previous);
        }
    }
}