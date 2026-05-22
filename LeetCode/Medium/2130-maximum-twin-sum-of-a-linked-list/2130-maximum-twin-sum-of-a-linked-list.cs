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
    public int PairSum(ListNode head) {
        var firstHalfEnd = GetLastOfFirstHalf(head);
        var secondHalf = firstHalfEnd.next;
        firstHalfEnd.next = null;
        var reversedHead = ReverseLinkedList(secondHalf);
        
        var max = FindTwinMax(head, reversedHead);

        var secondHalfStart = ReverseLinkedList(reversedHead);
        firstHalfEnd.next = secondHalfStart;

        return max;
    }

    private ListNode GetLastOfFirstHalf(ListNode node)
    {
        var slow = node;
        var fast = node.next;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    private int FindTwinMax(ListNode straight, ListNode reversed)
    {
        var max = int.MinValue;
        while (reversed != null)
        {
            max = Math.Max(reversed.val + straight.val, max);
            straight = straight.next;
            reversed = reversed.next;
        }

        return max;
    }

    private ListNode ReverseLinkedList(ListNode node)
    {
        ListNode previous = null;
        while (node != null)
        {
            var next = node.next;
            node.next = previous;
            previous = node;
            node = next;
        }

        return previous;
    }
}