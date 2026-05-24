/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        var pPath = GetNodePath(root, p);
        var qPath = GetNodePath(root, q);

        var lowerCount = pPath.Count < qPath.Count ? pPath.Count : qPath.Count;

        var previous = root;
        for (var i = 1; i < lowerCount; i++)
        {
            if (pPath[i].val != qPath[i].val) return previous;

            previous = pPath[i];
        }

        return pPath[lowerCount - 1];
        return root;

        static List<TreeNode> GetNodePath(TreeNode root, TreeNode node)
        {
            const int reasonableStartSize = 32;
            var stack = new Stack<TreeNode>(reasonableStartSize);
            var path = new List<TreeNode>(reasonableStartSize);

            var current = root;
            TreeNode lastVisited = null;
            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    path.Add(current);
                    if (current.val == node.val) return path;

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
                    var popNode = stack.Pop();
                    lastVisited = popNode;
                    path.RemoveAt(path.Count - 1);
                }
            }

            throw new System.Diagnostics.UnreachableException("Didn't found a node!");
        }
    }
}