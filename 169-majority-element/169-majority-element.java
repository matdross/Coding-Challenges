class Solution {
    public int majorityElement(int[] nums) {
        
        int L = nums.length;
        HashMap<Integer, Integer> map = new HashMap<>();
        
        for(int i=0; i<L; i++) {
            if(map.containsKey(nums[i])) {
                if(map.get(nums[i]) >= L/2)
                    return nums[i];
                map.replace(nums[i], map.get(nums[i])+1);
            }
            else
                map.put(nums[i], 1);
        }
        return nums[L-1];
        
    }
}