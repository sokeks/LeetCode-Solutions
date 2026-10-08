# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def generateTrees(self, n: int) -> list[TreeNode | None]:
    # recursive version, when each tree is dependent, we use existing trees - less time, but less prouction ready (fulfill tasks)
    # version with dependent trees is much easier in recursive version, comparing to iterative

        def build_trees(start: int, end: int) -> list[TreeNode]:
            if start > end:
                return [None]
            
            trees = []
            for root in range(start, end + 1):
                left_trees = build_trees(start, root - 1)
                right_trees = build_trees(root + 1, end)
                for left in left_trees:
                    for right in right_trees:
                        trees.append(TreeNode(val=root, left=left, right=right))

            return trees

        return build_trees(1, n)  

    # # each tree is dependent, we use existing trees - less time, but less prouction ready (fulfill tasks)
    #     dp = [TreeNode(val=i) for i in range(n)]

    #     for i in range(1, n + 1):
    #         trees = []
    #         for root in range(1, i + 1):
    #             left_trees = [dp[j] for j in range(root)]
    #             right_trees = [dp[j] if j < len(dp) else None for j in range(root + 1, i + 1)]
                
    #             for left in left_trees:
    #                 for right in right_trees:
    #                     trees.append(TreeNode(val=root, left=left, right=right))
                
    #         dp.append(trees)

    #     return dp[-1]


    # each tree is independent, we do a full copy with adding new node - more time, but more production type of solution (however not requested by the task)
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
        