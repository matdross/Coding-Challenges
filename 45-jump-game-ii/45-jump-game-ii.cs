public class Solution {
    public int Jump(int[] nums) {
        
        if(nums.Length < 1 || nums.Length > 10000) return default;
        
        int jumpCount = 0, furthest = -1, target = 0;
        
        for (int i = 0; i < nums.Length - 1; i++)
        {
            furthest = Math.Max(nums[i] + i, furthest);
            if (i == target)
            {
                jumpCount++;
                target = furthest;
            }
        }
        return jumpCount;        
    }
}