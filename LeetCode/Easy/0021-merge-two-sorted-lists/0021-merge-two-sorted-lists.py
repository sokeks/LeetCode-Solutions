# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        # without sentinel, less clean, but no allocation - with sentinel, see below
        current = head = None
        while list1 and list2:
            if list1.val < list2.val:
                nxt = list1
                list1 = list1.next
            else:
                nxt = list2
                list2 = list2.next
            
            if head is None:
                current = head = nxt
            else:
                current.next = nxt
                current = current.next
        
        if head is None:
            return list1 or list2
        
        current.next = list1 or list2
        return head


        # with sentinel, clearer, but additional allocation
        sentinel = ListNode()
        current = sentinel
        while list1 or list2:
            if list1.val < list2.val:
                current.next = list1
                list1 = list1.next
            else:
                current.next = list2
                list2 = list2.next

            current = current.next

        current.next = list1 or list2
        
        return sentinel.next