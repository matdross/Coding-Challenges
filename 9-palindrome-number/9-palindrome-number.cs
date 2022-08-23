public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0 || (x != 0 && x %10 == 0)) return false;
        if(x == 0) return true;
        
        int rev = 0;
        
        while(x > rev) {
            int pop = x % 10;
            x /= 10;
            
            rev = (rev * 10) + pop;
        }
        if(x == rev || x == rev / 10 ) {
            return true;
        }
        return false;
    }
}