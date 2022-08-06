public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        if(nums.Length < 1 || nums.Length > 100 || val < 0 || val > 100) 
            return nums.Count();
        
        int position = 0;
        
        for(int i = 0; i< nums.Length; i++)
        {
            if(nums[i] != val)
            {
                nums[position] = nums[i];
                position++;
            }
        }
                
        return position;

    }
}
/*
Notes
setting the position value to current iteration if it does not match and icrement.
if it matches do not increment postion
therefor, next time iteration equals value, the postion (which is the matched value) 
becomes the value that is not matched
*/