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
    public IList<int> PreorderTraversal(TreeNode root) {
        
        List<int> returnArr = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode cur = root;
        
        while(cur != null || stack.Count != 0) {
            if(cur != null) {
                returnArr.Add(cur.val);
                stack.Push(cur);
                cur = cur.left;
            }
            else {
                cur = stack.Pop();
                cur = cur.right;
            }
            
        }
        return returnArr;
    }
}