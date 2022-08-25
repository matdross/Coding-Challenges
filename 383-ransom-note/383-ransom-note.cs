public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        
        // - a gives the index of a char in the english alphabet
        
        if(String.IsNullOrEmpty(ransomNote) || String.IsNullOrEmpty(magazine)) return false;
        if(magazine.Length < ransomNote.Length) return false;
        
        //Set a new array for size of alphabet
        int[] alphabets_counter = new int[26];
        
        //add increment each alphabet counter for every item found
        foreach (char c in magazine.ToCharArray()) {
            alphabets_counter[c-'a']++;
        }
        
        //iterate the randsom and determin if that item has a count in alphabetcounter
        foreach (char c in ransomNote.ToCharArray()) {
            if (alphabets_counter[c-'a'] == 0) return false;
            alphabets_counter[c-'a']--;
        }
        return true;
    }
}