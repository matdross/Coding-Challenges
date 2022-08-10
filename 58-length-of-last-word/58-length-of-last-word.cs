public class Solution {
    public int LengthOfLastWord(string s) {
        
        var splitString = s.Split(" ");
        var filtered = splitString.Where(x => !String.IsNullOrEmpty(x)).ToArray();
        
        return filtered[filtered.Length - 1].Count();
        
    }
}