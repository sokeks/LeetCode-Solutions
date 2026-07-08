# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isBalanced(self, root: Optional[TreeNode]) -> bool:
        stack: list[TreeNode] = []
        heights = []
        current = root
        last_visited = None


        while stack or current:
            while current:
                stack.append(current)
                current = current.left
            
            node = stack[-1]                
            if node.right and node.right != last_visited:
                current = node.right
            else:
                right_depth = 0 if not node.right else heights.pop()
                left_depth = 0 if not node.left else heights.pop()
                if abs(right_depth - left_depth) > 1:
                    return False
                depth = max(left_depth, right_depth) + 1
                heights.append(depth)

                last_visited = stack.pop()

        return True



        