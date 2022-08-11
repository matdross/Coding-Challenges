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
    public IList<IList<int>> LevelOrder(Node root) {
        List<IList<int>> res = new List<IList<int>>();
        if(root == null) return res;

        Queue<Node> que = new Queue<Node>();

        que.Enqueue(root);
        // Add first node
        while(que.Any()){
            int queCount = que.Count;
            List<int> temp = new List<int>();
            for(int i = 0; i< queCount; i++){
                var cur = que.Dequeue();
                temp.Add(cur.val);
                foreach(var item in cur.children){
                    if(item != null)
                        que.Enqueue(item);
                }
            }
            res.Add(temp);
        }
        return res;
    }
}