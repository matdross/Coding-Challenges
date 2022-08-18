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
    public ListNode MiddleNode(ListNode head) {
        
        if(head == null) return null;
        
        var count = 0.0;
        var cur = head;        
        
        while(cur.next != null) {
            cur = cur.next;
            count += 1;
        }
        
        count = count / 2; 

        cur = head;
        
        for(int i = 0; i < count; i++) {  
            cur = cur.next;
        }
        
        return cur;
    }
}