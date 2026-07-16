# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def binaryTreePaths(self, root: Optional[TreeNode]) -> List[str]:
        buffer = []
        current = root
        stack = []
        last_visited = None
        root_to_leaf_paths = []

        while current or stack:
            while current:
                buffer.append(str(current.val))
                stack.append(current)
                current = current.left

            node = stack[-1]
            if node.right and node.right is not last_visited:
                current = node.right
            else:
                stack.pop()
                if not node.left and not node.right:
                    root_to_leaf_paths.append("->".join(buffer))
                last_visited = node
                buffer.pop()
        
        return root_to_leaf_paths