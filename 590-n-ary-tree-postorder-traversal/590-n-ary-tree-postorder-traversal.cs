/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Postorder(Node root) {
        
        List<int> list = new List<int>();
        if (root == null) return list;
        
        Stack<Node> stack = new Stack<Node>();
        stack.Push(root);
        
        while (stack.Count > 0)
        {
            Node node = stack.Pop();
            list.Insert(0, node.val); // reversal of list adding to the start
            int count = node.children.Count - 1;

            foreach (var x in node.children)
            {
                stack.Push(x);
            }
        }
        return list;
        
    }
}