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
    public ListNode RemoveElements(ListNode head, int val) {
        var dummy = new ListNode();
        dummy.next = head;
        var current = dummy;
        while (current.next != null)
        {
            if (current.next.val == val)
            {
                var toRemove = current.next;    // 1st instruction of 2 for GC optimization
                current.next = current.next.next;
                toRemove.next = null;                // 2nd instruction of 2 for GC optimization
            }
            else
            {
                current = current.next;
            }
        }

        return dummy.next;
    }
}