public class Solution {
    public int RepeatedNTimes(int[] nums) {
        if(nums.Length == 0) return 0;
        var count = nums.Length / 2;

        Dictionary<int, int> dict = new();
        
        foreach(var x in nums) {
            if(!dict.ContainsKey(x)) 
                dict.Add(x, 1);
            else
                dict[x] = dict[x] + 1;
        }
        
        foreach(var v in dict) {
            if(v.Value == count)
                return v.Key;
        }
        return 0;
    }
}