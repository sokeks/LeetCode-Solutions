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

        var currentLevelCounter = 1;
        var nextLevelCounter = 0;

        const int reasonableQueueStartSize = 32;
        var queue = new Queue<TreeNode>(reasonableQueueStartSize);
        queue.Enqueue(root);

        var rightSideVisibleNodes = new List<int>(reasonableQueueStartSize);
        while (queue.Count > 0)
        {
            if (currentLevelCounter == 0)
            {
                currentLevelCounter = nextLevelCounter;
                nextLevelCounter = 0;
            }
            var node = queue.Dequeue();
            currentLevelCounter--;
            if (currentLevelCounter == 0) rightSideVisibleNodes.Add(node.val);

            if (node.left != null)
            {
                queue.Enqueue(node.left);
                nextLevelCounter++;
            }

            if (node.right != null)
            {
                queue.Enqueue(node.right);
                nextLevelCounter++;
            }
        }

        return rightSideVisibleNodes;
    }
}