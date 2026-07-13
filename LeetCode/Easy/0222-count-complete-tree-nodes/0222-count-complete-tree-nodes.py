# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    # recursive version - optimal one, due to certainty, it's not a skewed tree, but complete - so
    # depth -> O(log N) and code easiness
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

    # iterative version - theoretically more optimal, due to O(1) space complexity, but more complex and one-off error prone
    def countNodes(self, root: Optional[TreeNode]) -> int:
        def find_right_depth(root: TreeNode) -> int:
            depth = 0
            current = root
            while current:
                depth += 1
                current = current.right
            return depth

        if not root: return 0
        
        tree_depth = find_right_depth(root)
        print(tree_depth)
        nodes_sum = (1 << tree_depth) - 1

        left = 0
        right = 1 << tree_depth

        def does_node_exist(node: TreeNode, path: int):
            for i in range((tree_depth - 1), -1, -1):
                step = (path >> i) & 1

                node = node.left if not step else node.right
            print(bool(node))
            return bool(node)

        while left < right:
            mid = (left + right) // 2
            print(f"mid={mid}")

            if does_node_exist(root, mid):
                left = mid + 1
            else:
                right = mid


        print(f"left={left}")
        return nodes_sum + left
        