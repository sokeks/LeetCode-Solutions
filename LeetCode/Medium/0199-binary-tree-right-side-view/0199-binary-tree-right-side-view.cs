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
        if (root == null) return new int[0];

        var currentLevelNodesCount = 1;

        const int reasonableDataStructureStartSize = 32;
        var queue = new Queue<TreeNode>(reasonableDataStructureStartSize);
        queue.Enqueue(root);

        var rightSideVisibleNodes = new List<int>(reasonableDataStructureStartSize);
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node.left != null) queue.Enqueue(node.left);
            if (node.right != null) queue.Enqueue(node.right);

            currentLevelNodesCount--;
            if (currentLevelNodesCount == 0)
            {
                rightSideVisibleNodes.Add(node.val);
                currentLevelNodesCount = queue.Count;
            }
        }

        return rightSideVisibleNodes;
    }
}