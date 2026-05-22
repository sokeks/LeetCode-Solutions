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
    public TreeNode SortedArrayToBST(int[] nums) {
        // using recurence as with N=10^4 balanced tree depth is log(N) ~< 14 and even if it raises, it's very limited rising
        return SortedArrayToBST(nums, 0, nums.Length);
    }

    private TreeNode SortedArrayToBST(int[] nums, int left, int right)
    {
        var mid = left + (right - left) / 2;

        return left < right
            ? new TreeNode(nums[mid], SortedArrayToBST(nums, left, mid), SortedArrayToBST(nums, mid + 1, right))
            : null;
    }
}