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
    // iteration alternative
    public int CountNodes(TreeNode root) {
        if (root == null) return 0;

        var height = GetHeight(root);
        var low = 0;
        var high = (1 << (height - 1));

        while (low < high)
        {
            var mid = low + (high - low) / 2;

            var node = root;
            for (var i = height - 2; i >= 0; i--)
            {
                node = (mid & (1 << i)) == 0 ? node.left : node.right;
            }

            if (node != null)
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return (1 << (height - 1)) - 1 + low;
    }

    // recursion alternative
    public int CountNodesRec(TreeNode root) {
        if (root == null) return 0;

        var leftHeight = GetHeight(root, true);
        var rightHeight = GetHeight(root, false);

        if (leftHeight == rightHeight)
        {
            return (1 << leftHeight) - 1;
        }

        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }

    private int GetHeight(TreeNode node, bool goLeft)
    {
        var height = 0;
        while (node != null)
        {
            height++;
            node = goLeft ? node.left : node.right;
        }
        return height;
    }

        private int GetHeight(TreeNode node)
    {
        var height = 0;
        while (node != null)
        {
            height++;
            node = node.left;
        }
        return height;
    }
}