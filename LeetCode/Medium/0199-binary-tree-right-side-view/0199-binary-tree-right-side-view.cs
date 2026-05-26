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
    public IList<int> RightSideView(TreeNode root) {
        if (root == null) return Array.Empty<int>();

        const int defaultCapacity = 32;
        var queue = new Queue<TreeNode>(defaultCapacity);
        queue.Enqueue(root);

        var rightSideVisibleNodes = new List<int>(defaultCapacity);
        while (queue.Count > 0)
        {
            var currentLevelNodesCount = queue.Count;
            TreeNode node = null;
            for (var i = 0; i < currentLevelNodesCount; i++)
            {
                node = queue.Dequeue();
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            rightSideVisibleNodes.Add(node.val);
        }

        return rightSideVisibleNodes;
    }
}