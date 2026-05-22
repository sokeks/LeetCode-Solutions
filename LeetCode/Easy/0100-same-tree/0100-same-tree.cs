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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null || q == null)
        {
            return p == q;
        }
        var pStack = new Stack<TreeNode>(100);
        pStack.Push(p);
        var qStack = new Stack<TreeNode>(100);
        qStack.Push(q);



        while (pStack.Count > 0)
        {
            var pNode = pStack.Pop();
            var qNode = qStack.Pop();

            if (pNode.val != qNode.val)
            {
                return false;
            }

            if (pNode.right != null && qNode.right != null)
            {
                pStack.Push(pNode.right);
                qStack.Push(qNode.right);
            }
            else if (pNode.right != null || qNode.right != null)
            {
                return false;
            }

            if (pNode.left != null && qNode.left != null)
            {
                pStack.Push(pNode.left);
                qStack.Push(qNode.left);
            }
            else if (pNode.left != null || qNode.left != null)
            {
                return false;
            }
        }

        return true;        
    }
}