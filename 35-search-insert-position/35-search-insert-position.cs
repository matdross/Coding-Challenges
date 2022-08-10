public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        if(nums.Length < 1 || nums.Length > 10000)
            return -1; 
        if(target < -10000 || target > 10000)
            return -1; 
        
        var len = nums.Length;
        var left = -1;
        var right = len;
        
        while(right > left + 1) {
            int middle = (left + right) / 2;
            if (nums[middle] >= target)
                right = middle;
            else
                left = middle;
        }
        //This checks if the target has been found, however
        //thats not neccesary here as we only want to return
        //the position even if its not found and out of bounds
        //if (right < nums.Length && nums[right] == target)
        return right;
    }
}