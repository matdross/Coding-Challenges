public class Solution {
    public int StrStr(string haystack, string needle) {
        if(haystack.Length < 1 
           || haystack.Length > 10000 
           || String.IsNullOrEmpty(needle))
            return 0;
        
        if(haystack.Contains(needle)) {
            for(int i=0; i<haystack.Length-needle.Length+1; i++){
                if(haystack.Substring(i, needle.Length) == needle){
                    return i;
                }
            }
        }
        
        return -1;
    }
}