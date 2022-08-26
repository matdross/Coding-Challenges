public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        if(nums.Length < 1 ) return 0;
        
        Dictionary<int, int> dict = new();
        
        foreach(var x in nums) {
            if (!dict.ContainsKey(x))
            {
                dict.Add(x, 1);
            }
            else
            {
                dict[x] = dict[x]+1;
            }
        }
        var total = 0;
        foreach(var item in dict.Values) {
            if(item > 0) {
                total += (item * (item-1) / 2);
            } 
        }   
        return total;
    }
}