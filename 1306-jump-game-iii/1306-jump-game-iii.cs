public class Solution {
    public bool CanReach(int[] arr, int start) {
        
        var visited = new HashSet<int>();
        int count = 0;
        
        var queue = new Queue<int>();
        queue.Enqueue(start);
        
        while (queue.Count > 0) {
            var vertex = queue.Dequeue();
            //move point left - arr[vertex]
            if(vertex - arr[vertex] >= 0 ) {
                if(arr[vertex - arr[vertex]] == 0)
                    return true;
                else if(arr[vertex - arr[vertex]] > 0)
                    queue.Enqueue(vertex - arr[vertex]);
                    
            }
            //move point right + arr[vertex]
            if(vertex + arr[vertex] < arr.Length) {
                if(arr[vertex + arr[vertex]] == 0)
                    return true;
                else if(arr[vertex + arr[vertex]] > 0)
                    queue.Enqueue(vertex + arr[vertex]);        
            }
            arr[vertex] = -1;
        }
        return false;
    }
}