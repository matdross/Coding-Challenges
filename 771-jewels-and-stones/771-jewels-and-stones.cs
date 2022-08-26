public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        if(jewels == "" || stones == "") return 0;
        
        Dictionary<int, int> dict = new();
        
        foreach(char x in stones) {
            if(!dict.ContainsKey(x)) 
                dict.Add(x, 1);
            else
                dict[x] = dict[x] + 1;
        }
        
        var total = 0;
        foreach(char v in jewels) {
            if(dict.ContainsKey(v)) 
                total += dict[v];
        }
        return total;
    }
}