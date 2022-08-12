/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        var cur = root;
        
        while(cur != null) {
            if(cur.val < p.val && cur.val < q.val) {
                cur = cur.right;
            }
            else if(cur.val > p.val && cur.val > q.val) {
                cur = cur.left;
            }
            else{
                return cur;
            }
        }
        return cur;
    }
}