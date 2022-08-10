public class Solution {
    public bool CanJump(int[] nums) {
        int lastGoodPos = nums.Length - 1;
        
        for(int i = nums.Length - 1; i >= 0; i--) {
            if(i + nums[i] >= lastGoodPos) {
                lastGoodPos = i;
            }
        }
        return lastGoodPos == 0;
    }
}