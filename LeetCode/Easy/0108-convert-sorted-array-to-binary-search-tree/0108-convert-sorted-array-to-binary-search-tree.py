# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def sortedArrayToBST(self, nums: List[int]) -> Optional[TreeNode]:
        left = 0
        right = len(nums)
        mid = (left + right) // 2
        root = TreeNode(val=nums[mid])

        stack: list[tuple[TreeNode, tuple[int, int], tuple[int, int]]] = [(root, (left, mid), (mid + 1, right))]

        while stack:
            node, (left_left, left_right), (right_left, right_right) = stack.pop()
            if right_left < right_right:
                mid = (right_left + right_right) // 2
                node.right = TreeNode(val=nums[mid])
                stack.append((node.right, (right_left, mid), (mid + 1, right_right)))
            
            if left_left < left_right:
                mid = (left_left + left_right) // 2
                node.left = TreeNode(val=nums[mid])
                stack.append((node.left, (left_left, mid), (mid + 1, left_right)))

        return root



        