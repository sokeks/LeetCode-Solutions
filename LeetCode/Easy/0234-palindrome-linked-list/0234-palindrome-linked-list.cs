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
    public bool IsPalindrome(ListNode head) {

        var slow = head;
        var fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        var reversed = ReverseList(slow);
        var areListsEqual = AreListEqual(head, reversed);

        ReverseList(reversed);
        return areListsEqual;
    }

    private ListNode ReverseList(ListNode node)
    {
        ListNode previous = null;
        ListNode current = node;

        while (current != null)
        {
            var next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        return previous;
    }

    private bool AreListEqual(ListNode first, ListNode second)
    {
        while (second != null)
        {
            if (first.val != second.val) return false;

            first = first.next;
            second = second.next;
        }

        return true;
    }
}