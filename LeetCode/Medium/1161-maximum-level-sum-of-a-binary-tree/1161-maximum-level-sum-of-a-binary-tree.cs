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

        var maxSum = 0;
        var maxSumLevel = 0;

        var currentLevel = 1;

        while (queue.Count > 0)
        {
            var levelNodesCount = queue.Count;
            var currentSum = 0;
            for (var i = 0; i < levelNodesCount; i++)
            {
                var node = queue.Dequeue();
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
                
                currentSum += node.val;
            }

            if (maxSumLevel == 0 || currentSum > maxSum)
            {
                maxSum = currentSum;
                maxSumLevel = currentLevel;
            }

            currentLevel++;
        }

        return maxSumLevel;
    }
}