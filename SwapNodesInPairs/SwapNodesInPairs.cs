/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class SwapNodesInPairs {
    public ListNode SwapPairs(ListNode head) 
    {
        ListNode ans = new ListNode(-1);
        ans.next = head;
        ListNode cur = head;
        ListNode prev = ans;
        
        ListNode tmp;
        
        while(cur != null && cur.next != null)
        {
            tmp = cur.next.next;
            cur.next.next = cur;
            prev.next = cur.next;
            cur.next = tmp;
            prev = cur;
            cur = cur.next;
        }
        
        return ans.next;
    }
}