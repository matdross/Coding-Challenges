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
    public ListNode DeleteDuplicates(ListNode head) {

        ListNode cur = head;
        
        while(cur != null) {
            while(cur.next != null && cur.val == cur.next.val ) {
                cur.next = cur.next.next;
            }
            cur = cur.next;                   
        }
        return head;
    }
}