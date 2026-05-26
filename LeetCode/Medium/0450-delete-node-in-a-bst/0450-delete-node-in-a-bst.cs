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

        if (deleteNode.left == null && deleteNode.right == null)
        {
            if (previous.left == deleteNode) previous.left = null;
            else previous.right = null;
        }
        else
        {
            ApplyHibardReplacement(deleteNode);
        }


        return sentinel.left;
        static (TreeNode, TreeNode) FindDeleteNode(TreeNode current, TreeNode previous, int key)
        {
            while (current != null)
            {
                if (current.val == key) return (current, previous);
                
                previous = current;
                if (current.val > key) current = current.left;
                else current = current.right;
            }

            return (null, previous);
        }
        static void ApplyHibardReplacement(TreeNode deleteNode)
        {
            var previous = deleteNode;
            TreeNode current = null;
            if (deleteNode.left != null)
            {
                current = deleteNode.left;
                while (current.right != null)
                {
                    previous = current;
                    current = current.right;
                }

                if (current == deleteNode.left)
                {
                    deleteNode.left = current.left;
                }
                else
                {
                    // Console.WriteLine($"{previous.val} {current.val}");
                    previous.right = current.left;
                }
            }
            else
            {
                current = deleteNode.right;
                while (current.left != null)
                {
                    previous = current;
                    current = current.left;
                }
                
                if (current == deleteNode.right)
                {
                    deleteNode.right = current.right;
                }
                else
                {
                    previous.left = current.right;
                }

            }
            deleteNode.val = current.val;
        }
    }

}