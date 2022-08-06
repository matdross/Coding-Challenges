public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        if(nums.Count() <= 0 && nums.Count() >= 30000)
            return default;
        
        int position = 0;
        
        for(int i = 0; i < nums.Count(); i++) {
            if(nums[i] != nums[position]) {
                //Shift
                nums[++position] = nums[i];
            } 
        }
        //increment from 0 starting point
        return position + 1;
    }
}