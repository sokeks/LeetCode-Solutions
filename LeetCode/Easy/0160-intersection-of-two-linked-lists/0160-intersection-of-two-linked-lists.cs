/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        var (lengthA, lastA) = GetLengthAndLastNode(headA);
        var (lengthB, lastB) = GetLengthAndLastNode(headB);
        if (lastA != lastB) return null;

        var (longer, shorter) = lengthA > lengthB
            ? (headA, headB)
            : (headB, headA);

        for (var i = 0; i < Math.Abs(lengthA - lengthB); i++)
        {
            longer = longer.next;
        }

        while (longer != shorter)
        {
            longer = longer.next;
            shorter = shorter.next;
        }

        return longer;
    }

    private (int, ListNode) GetLengthAndLastNode(ListNode node)
    {
        var length = 1;
        while (node.next != null)
        {
            node = node.next;
            length++;            
        }

        return (length, node);
    }
}