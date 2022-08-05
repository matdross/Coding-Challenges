public class Solution {
    public bool IsValid(string s) {
        //Check the char, check if +1 is opposite
        
        if(String.IsNullOrEmpty(s) || s.Length > 10000){
            return default;
        }
        
        Stack<char> stack = new Stack<char>();
        Dictionary<char,char> dict = new Dictionary<char,char>();
        dict.Add('[',']');
        dict.Add('{','}');
        dict.Add('(',')');
        
        foreach(char c in s)
        {
            if(dict.ContainsKey(c)) {
                stack.Push(dict[c]);
            }
            else if(stack.Count == 0 || stack.Pop() != c ) 
                return false;
        }
        return stack.Count == 0;
    }
}