public class Solution {
    public int[] SortedSquares(int[] nums) {
        
        List<int> sorted = new List<int>();
        int l = 0, r = nums.Length - 1;
        
        while (l <= r) {
            var ls = nums[l] * nums[l];
            var rs = nums[r] * nums[r];
            if(ls > rs) {
                sorted.Insert(0,ls);
                l ++;
            }
            else {
                sorted.Insert(0,rs);
                r --;
            }
        }
        
        return sorted.ToArray();
    }
}