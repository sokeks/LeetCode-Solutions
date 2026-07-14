# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def isPalindrome(self, head: Optional[ListNode]) -> bool:
        def find_after_mid_node(current: ListNode) -> ListNode:
            slow = head
            fast = head
            while fast and fast.next:
                fast = fast.next.next
                slow = slow.next
            
            return slow

        def reverse_list(current: ListNode) -> ListNode:
            previous = None
            while current:
                current.next, previous, current = previous, current, current.next 
            
            return previous

        def compare_reversed_with_straight(reversed_half: ListNode, straight_half: ListNode) -> bool:
            second_half_head = reversed_half
            while reversed_half:
                if straight_half.val != reversed_half.val:
                    reverse_list(second_half_head)
                    return False
                reversed_half = reversed_half.next
                straight_half = straight_half.next
        
            reverse_list(second_half_head)
            return True

        second_half_head = reverse_list(find_after_mid_node(head))
        return compare_reversed_with_straight(second_half_head, head)
        
        

        