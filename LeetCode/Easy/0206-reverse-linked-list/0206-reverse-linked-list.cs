/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseListIter(ListNode head) {
        ListNode previous = null;
        ListNode current = head;
        while (current != null)
        {
            var next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        return previous;
        
    }

    public ListNode ReverseList(ListNode head) {
        return ReverseListRec(null, head);
    }

    public ListNode ReverseListRec(ListNode previous, ListNode current) {
        if (current == null)
        {
            return previous;
        }
        var next = current.next;
        current.next = previous;

        return ReverseListRec(current, next);
    }
}