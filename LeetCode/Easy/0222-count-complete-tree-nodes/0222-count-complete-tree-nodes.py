# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def countNodes(self, root: Optional[TreeNode]) -> int:
        if not root: return 0
        queue = deque([root])
        node_sum = 1

        while True:
            queue_len = len(queue)

            for _ in range(queue_len):
                n = queue.popleft()
                if n.left:
                    queue.append(n.left)
                if n.right:
                    queue.append(n.right)
            
            node_sum += len(queue)
            if len(queue) != 2 * queue_len:
                return node_sum

        assert_never()



        