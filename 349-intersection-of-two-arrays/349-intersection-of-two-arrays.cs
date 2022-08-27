public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        if(nums1.Length < 1 || nums2.Length < 1) return default;
        
        HashSet<int> sets = new HashSet<int>(nums2);
        HashSet<int> intersection = new HashSet<int>(nums1);
        
        sets.IntersectWith(intersection);
        return sets.ToArray();
        
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

/*
HashSet<Integer> set = new HashSet<Integer>();
for(int i: nums1){
    set.add(i);
}

HashSet<Integer> intersection = new HashSet<Integer>();
for(int i: nums2){
    if(set.contains(i)){
        intersection.add(i);
    }
}
int[] result = new int[intersection.size()];
int index = 0;
for(int i: intersection){
    result[index++] = i;
}

return result;
*/