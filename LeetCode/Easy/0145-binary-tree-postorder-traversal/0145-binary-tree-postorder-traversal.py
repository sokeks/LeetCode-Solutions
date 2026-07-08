# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def postorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        if not root: return []

        stack = []
        current = root
        last_visited = None

        output = []

        while stack or current:
            while current:
                stack.append(current)
                current = current.left
            
            node = stack[-1]
            if node.right and node.right is not last_visited:
                current = node.right
            else:
                output.append(node.val)
                last_visited = node
                stack.pop()
        
        return output

        