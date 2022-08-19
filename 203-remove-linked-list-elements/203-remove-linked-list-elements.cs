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
        if(head == null) return null;
        ListNode fakeHead = new ListNode();
        ListNode prev = null, cur = null;
        
        fakeHead.next = head;
        cur = fakeHead.next;
        prev = fakeHead;
        
        while(cur != null) {
            
            if(cur.val == val) {
                prev.next = cur.next;
                cur = cur.next;
            }
            else {
                prev = cur;
                cur = cur.next; 
            }

        }
        
        return fakeHead.next;
        
    }
}