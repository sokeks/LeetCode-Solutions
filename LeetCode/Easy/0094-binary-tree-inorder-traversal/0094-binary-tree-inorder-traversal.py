# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def inorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        current = root
        stack = []
        output = []

        while current or stack:
            while current:
                stack.append(current)
                current = current.left
            
            node = stack.pop()
            output.append(node.val)
            if node.right is not None:
                current = node.right
            
        return output
        


        