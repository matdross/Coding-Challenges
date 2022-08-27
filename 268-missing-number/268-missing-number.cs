public class Solution {
    public int MissingNumber(int[] nums) {
        
        int res = nums.Length;
        for(int i=0; i<nums.Length; i++){
            res ^= i;
            res ^= nums[i];
        }
        return res;
        
    }
}
/*
res = 011
0 => 011 ^ 000 = 011 ^ 011 = 000
res = 0
1 => 000 ^ 001 = 001 ^ 000 = 001
res = 1
2 => 001 ^ 010 = 011 ^ 001 = 010
   
*/

