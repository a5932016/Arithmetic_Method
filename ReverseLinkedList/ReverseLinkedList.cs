/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class ReverseLinkedList {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;
        
        while (curr != null)
        {
            head = curr.next;
            curr.next = prev;
            prev = curr;
            curr = head;
        }
        
        return prev;
    }
}