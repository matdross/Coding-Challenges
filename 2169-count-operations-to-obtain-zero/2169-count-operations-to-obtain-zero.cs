public class Solution {
    public int CountOperations(int num1, int num2) {
        var counter = 0;
        while(num1 != 0 && num2 != 0) {
            if(num1 < num2) num2 = num2 - num1;
            else num1 = num1 - num2;
            counter ++;
        }
        return counter;
    }
}