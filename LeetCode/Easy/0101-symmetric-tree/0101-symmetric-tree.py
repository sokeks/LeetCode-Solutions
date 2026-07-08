# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isSymmetric(self, root: Optional[TreeNode]) -> bool:
        stack: List[Tuple[TreeNode, TreeNode]] = []
        stack.append((root.left, root.right))

        while stack:
            left, right = stack.pop()
            if left is None and right is None:
                continue
            if left is None or right is None or left.val != right.val:
                return False
            
            stack.append((left.right, right.left))
            stack.append((left.left, right.right))
        
        return True