public class Solution {
    public bool WordPattern(string pattern, string s) {
        if (String.IsNullOrEmpty(pattern) || String.IsNullOrEmpty(s)) return false;
            
        Dictionary<char,string> map1 = new Dictionary<char, string>();
        Dictionary<string,bool> map2 = new Dictionary<string, bool>();
            
        string[] arr = s.Split(" ");
        if(arr.Length != pattern.Count()) return false;
            
        for (int i = 0; i < arr.Length; i++) {
            char ch = pattern[i];
            
            if(!map1.ContainsKey(ch)) {
               if(map2.ContainsKey(arr[i]) )
                   return false;
                else{ 
                    map2.Add(arr[i], true); 
                    map1.Add(ch, arr[i]); 
                }
            }
            else {
                if(map1[ch] != arr[i]) return false;
            }
            
        }
        return true;
    }
}