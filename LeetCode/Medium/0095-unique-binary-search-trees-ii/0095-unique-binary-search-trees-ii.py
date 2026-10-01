# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def generateTrees(self, n: int) -> list[TreeNode | None]:
        previous_bsts = [TreeNode(val=1)]

        def copy_tree_with_dummy(tree: TreeNode) -> TreeNode:
            head = TreeNode(right=TreeNode(val=tree.val))
            stack = [(tree, head.right)]
            while stack:
                old, new = stack.pop()
                if old.left is not None:
                    new.left = TreeNode(val=old.left.val)
                    stack.append((old.left, new.left))
                if old.right is not None:
                    new.right = TreeNode(val=old.right.val)
                    stack.append((old.right, new.right))
            
            return head


        for i in range(2, n + 1):
            current_bsts = []
            for bst in previous_bsts:
                target_pos = 0
                while True:
                    new_bst = copy_tree_with_dummy(bst)
                    new_node = TreeNode(val=i)
                    
                    current_node = new_bst
                    pos = 0
                    while current_node.right is not None and pos < target_pos:
                        current_node = current_node.right
                        pos += 1

                    new_node.left = current_node.right
                    current_node.right = new_node

                    current_bsts.append(new_bst.right)
                    if new_node.left is None:
                        break

                    target_pos += 1

            previous_bsts = current_bsts

        return previous_bsts
        