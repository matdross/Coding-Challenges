public class Solution {
    public int StrStr(string haystack, string needle) {
        if(haystack.Length < 1 
           || haystack.Length > 10000 
           || String.IsNullOrEmpty(needle))
            return 0;
        
        if(haystack.Contains(needle)) {
            return haystack.IndexOf(needle);
        }

        return -1;
    }
}