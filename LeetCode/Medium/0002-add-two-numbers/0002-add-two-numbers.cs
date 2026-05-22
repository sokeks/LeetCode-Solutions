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

public class Result {
    public int carry;
    public ListNode list;
    public Result(int carry, ListNode list)
    {
        this.carry = carry;
        this.list = list;
    }
}
public class Solution {

    public int GetLength(ListNode current) =>
        current == null ? 0 : 1 + GetLength(current.next);
    public ListNode GetLast(ListNode current) =>
        current.next == null ? current : GetLast(current.next);
    public ListNode GetZeroList(int zerosNum, ListNode next) =>
        zerosNum == 0 ? next : GetZeroList(zerosNum - 1, new ListNode(0, next));

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var length1 = GetLength(l1);
        var length2 = GetLength(l2);

        var shorterList = length1 > length2 ? l2 : l1;
        GetLast(shorterList).next = GetZeroList(Math.Abs(length1 - length2), null);
        var resultFirst = new ListNode(0, null);
        var resultLast = resultFirst;
        var carry = 0;
        while (l1 != null)
        {
            resultLast.next = new ListNode((l1.val + l2.val + carry) % 10, null);
            carry = (l1.val + l2.val + carry) / 10;
            resultLast = resultLast.next;
            l1 = l1.next;
            l2 = l2.next;
        }
        
        if (carry == 1)
        {
            resultLast.next = new ListNode(1, null); 
        }

        return resultFirst.next;
    }
}