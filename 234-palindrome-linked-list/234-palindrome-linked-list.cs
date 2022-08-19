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
        //Stack LIFO
        
        if(head == null)
            return true;
        
        Stack<int> stack = new Stack<int>();
        ListNode curr = head;
        
        //Push all to stack, this is reversed order
        while(curr != null)
        {
            stack.Push(curr.val);
            curr = curr.next;
        }
        
        curr = head;
        while(curr != null)
        {
            //Check if stack values ==
            if(stack.Count == 0 || stack.Peek() != curr.val)
                return false;
            
            stack.Pop();
            curr = curr.next;
        }
        
        return stack.Count == 0;
    }
}