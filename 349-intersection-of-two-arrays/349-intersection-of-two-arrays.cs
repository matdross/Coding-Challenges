public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        if(nums1.Length < 1 || nums2.Length < 1) return default;
        
        HashSet<int> sets = new HashSet<int>(nums1);
        HashSet<int> intersection = new HashSet<int>();       
        
        foreach(var i in nums2) {
            if(sets.Contains(i)) {
                intersection.Add(i);
            }
         }
        int[] result = new int[intersection.Count()];
        int index = 0;
        foreach(var i in intersection){
            result[index++] = i;
        }
        
        return result;
    }
}