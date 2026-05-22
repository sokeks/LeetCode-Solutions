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
    public IList<string> BinaryTreePaths(TreeNode root) {
        var results = new List<string>();
        var path = new List<int>();
        
        TreeNode lastVisited = null;
        var current = root;
        var stack = new Stack<TreeNode>();

        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                path.Add(current.val);
                current = current.left;
            }

            var peeked = stack.Peek();
            if (peeked.right != null && peeked.right != lastVisited)
            {
                current = peeked.right;
            }
            else
            {
                lastVisited = peeked;
                if (peeked.left == null && peeked.right == null)
                {
                    results.Add(string.Join("->", path));
                }
                stack.Pop();

                path.RemoveAt(path.Count - 1);
            }
        }

        return results;
    }
}