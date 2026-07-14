# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def isPalindrome(self, head: Optional[ListNode]) -> bool:
        def reverse_list(current: Optional[ListNode]) -> ListNode:
            previous = None
            while current:
                current.next, previous, current = previous, current, current.next 
            
            return previous

        slow = head
        fast = head

        while fast and fast.next:
            fast = fast.next.next
            slow = slow.next

        second_half_head = reverse_list(slow)
        second_half_node = second_half_head
        first_half_node = head
        while second_half_node:
            if first_half_node.val != second_half_node.val:
                reverse_list(second_half_head)
                return False
            second_half_node = second_half_node.next
            first_half_node = first_half_node.next
        
        reverse_list(second_half_head)
        return True

        