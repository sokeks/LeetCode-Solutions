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
    public int MaxLevelSum(TreeNode root) {
        var defaultCapacity = 32;
        var queue = new Queue<TreeNode>(defaultCapacity);
        queue.Enqueue(root);

        var levelMaxSum = root.val;
        var levelMaxLevel = 1;

        var currentLevel = 1;
        var currentSum = 0;
        var levelNodesCount = queue.Count;

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            levelNodesCount--;

            if (node.left != null) queue.Enqueue(node.left);
            if (node.right != null) queue.Enqueue(node.right);

            currentSum += node.val;

            if (levelNodesCount == 0)
            {
                if (currentSum > levelMaxSum)
                {
                    levelMaxSum = currentSum;
                    levelMaxLevel = currentLevel;
                } 
                levelNodesCount = queue.Count;
                currentLevel++;

                currentSum = 0;
            }
        }

        return levelMaxLevel;
    }
}