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
        if(head==null) return null;
        
        ListNode preHead=new ListNode(0);
        preHead.next=head;
        ListNode pre=preHead;
        ListNode cur=head;
        
        while(cur!=null){
            while(cur.next !=null && cur.val == cur.next.val){
                cur = cur.next;
            }
            if(pre.next == cur){
                pre = pre.next;
            }
            else{
                pre.next = cur.next;
            }
            cur = cur.next;
        }
        return preHead.next;
    }
}