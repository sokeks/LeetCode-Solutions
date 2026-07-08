# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def getIntersectionNode(self, headA: ListNode, headB: ListNode) -> Optional[ListNode]:
        def get_length(n: ListNode):
            length = 0
            while n:
                n = n.next
                length += 1
            
            return length
        
        def get_adjusted_head(head: ListNode, list_length: int, other_list_length: int):
            if list_length > other_list_length:
                for _ in range(list_length - other_list_length):
                    head = head.next
            
            return head


        len_a = get_length(headA)
        len_b = get_length(headB)

        current_a = get_adjusted_head(headA, len_a, len_b)
        current_b = get_adjusted_head(headB, len_b, len_a)

        while current_a:
            if current_a is current_b:
                return current_a
            
            current_a = current_a.next
            current_b = current_b.next

        return None
        