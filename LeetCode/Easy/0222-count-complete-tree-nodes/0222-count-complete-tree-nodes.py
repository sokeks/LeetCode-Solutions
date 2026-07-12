# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def countNodes(self, root: Optional[TreeNode]) -> int:
        def find_left_depth(root: TreeNode) -> int:
            depth = 0
            current = root
            while current:
                depth += 1
                current = current.left
            return depth

        def find_right_depth(root: TreeNode) -> int:
            depth = 0
            current = root
            while current:
                depth += 1
                current = current.right
            return depth
        
        if not root:
            return 0

        lh = find_left_depth(root)
        rh = find_right_depth(root)

        if lh == rh:
            return (1 << lh) - 1
        
        return 1 + self.countNodes(root.left) + self.countNodes(root.right)



        # if not root: return 0

        # def find_right_depth(root: TreeNode) -> int:
        #     depth = 0
        #     current = root
        #     while current:
        #         depth += 1
        #         current = current.right
        #     return depth

        # def get_if_exist_child_nodes(node: TreeNode, path: int) -> Tuple[bool, bool]:
        #     while path:
        #         path, reminder = divmod(path, 2)
        #         node = node.right if reminder else node.left

        #     return (bool(node.left), bool(node.right))

        # tree_depth = find_right_depth(root)
        # print(tree_depth)
        # nodes_sum = (1 - 2**tree_depth) // (1 - 2)
        # print(nodes_sum)
        
        # left = 0
        # right = 2 ** (tree_depth - 1) - 1
        # mid = 0
        # while left < right:
        #     mid = (left + right + 1) // 2
        #     print(f"mid={mid}")

        #     left_exists, right_exists = get_if_exist_child_nodes(root, mid)
        #     print(f"{left_exists}, {right_exists}")

        #     if (left_exists, right_exists) == (True, False):
        #         print("stad return")
        #         return nodes_sum + (2 * mid + 1)
            
        #     if (left_exists, right_exists) == (False, False):
        #         right = mid - 1
        #     else:
        #         left = mid
        
        # return nodes_sum + left * 2


        