/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        
        List<int> inorderTraversal = new List<int>();
        
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;
        
        while (stack.Count > 0 || current != null) {
            if(current != null) {
                stack.Push(current);
                current = current.left;
            }
            else {
                current = stack.Pop();
                inorderTraversal.Add(current.val);
                current = current.right;
            }
        } 
        return inorderTraversal;
    }
}