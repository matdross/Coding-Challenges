public class Solution {
    public int NumberOfSteps(int num) {
        
        var counter = 0;
        
        while (num > 0) {
            if(num % 2 != 0) num = num - 1;
            else num = num / 2;
            counter ++;
        }
        
        return counter;
    }
}