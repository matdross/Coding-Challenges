public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        if(words.Length < 1) return 0;
        
        List<string> cur = new List<string>();
        List<string> morse = new List<string>(){".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        List<string> dict = new List<string>(){"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
        foreach (var word in words) {
            var s = "";
            for(int i = 0; i < word.Length; i++) {
                var o = dict.IndexOf(word[i].ToString());
                var m = morse[o];
                s += m;
            }  
            cur.Add(s);
        }
        
        return cur.Distinct().Count();
    }
}