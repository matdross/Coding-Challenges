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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if(head == null) return null;
        ListNode node = new ListNode(); 
        node.next = head;
        
        //Find the item
        ListNode pre = node; 
        for(int i = 0; i<left-1; i++) {
            pre = pre.next;
        } 

        ListNode start = pre.next; 
        ListNode next = start.next; 

        for(int i=0; i<right-left; i++)
        {
            start.next = next.next;
            next.next = pre.next;
            pre.next = next;
            next = start.next;
        }
        
        return node.next; //one after dummy
    }
}