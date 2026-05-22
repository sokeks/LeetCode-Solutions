/**
 * Definition for a binary tree node
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
    public int PathSum(TreeNode root, int targetSum) {
        if (root == null) return 0;

        var targetSumCount = 0;

        var currentSum = 0L;
        var prefixSumToFreq = new Dictionary<long, int>();
        prefixSumToFreq[currentSum] = 1;

        const int reasonableStartStackSize = 32;
        var stack = new Stack<TreeNode>(reasonableStartStackSize);
        var current = root;
        TreeNode lastVisited = null;
        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                currentSum += current.val;
                
                var residualSum = currentSum - targetSum;
                prefixSumToFreq.TryGetValue(residualSum, out int resFreq);
                targetSumCount += resFreq;
                
                prefixSumToFreq.TryGetValue(currentSum, out int currFreq);
                prefixSumToFreq[currentSum] = currFreq + 1;

                stack.Push(current);
                current = current.left;
            }

            var peekNode = stack.Peek();            
            if (peekNode.right != null && peekNode.right != lastVisited)
            {
                current = peekNode.right;
            }
            else
            {
                var node = stack.Pop();

                DecrementSumFreq(prefixSumToFreq, currentSum);
                currentSum -= node.val;

                lastVisited = node;
            }
        }

        return targetSumCount;
        static void DecrementSumFreq(Dictionary<long, int> dic, long key)
        {
            if (dic.TryGetValue(key, out int val) && val > 1)
            {
                dic[key] = val - 1;
            }
            else
            {
                dic.Remove(key);
            }
        }
    }


    // overcomplicated


    // public int PathSum(TreeNode root, int targetSum) {
    //     if (root == null) return 0;

    //     
    //     var stack = new Stack<(long sum, bool canStartNewPath, TreeNode node)>(reasonableStartStackSize);
    //     stack.Push((root.val, true, root));

    //     var targetSumCount = 0;
    //     while (stack.Count > 0)
    //     {
    //         var (sum, canStartNewPath, node) = stack.Pop();
    //         if (sum == targetSum) targetSumCount++;

    //         if (node.right != null)
    //         {
    //             if (canStartNewPath) stack.Push((node.right.val, false, node.right));
    //             stack.Push((sum + node.right.val, canStartNewPath, node.right));
    //         }
    //         if (node.left != null)
    //         {
    //             if (canStartNewPath) stack.Push((node.left.val, false, node.left));
    //             stack.Push((sum + node.left.val, canStartNewPath, node.left));
    //         }
    //     }
        
    //     v
    // }
}