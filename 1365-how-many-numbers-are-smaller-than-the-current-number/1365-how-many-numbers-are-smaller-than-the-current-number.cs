public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        if(nums.Length < 1) return nums;
        
        Dictionary<int,int> dict = new  Dictionary<int,int>();
        List<int> res = new List<int>();
        
        for(int i = 0 ; i< nums.Length ; i++)
        {
            var num = nums[i];
            if(dict.ContainsKey(num))
            {
              dict[num]++;
            }
            else
            {
              dict.Add(num, 1);
            }
        } 
        for(int i = 0 ; i < nums.Length; i++)
        {
            var num = nums[i];
            var smallerNumsSum = dict.Where(x=>x.Key < num).ToList().Sum(x=>x.Value);
            res.Add(smallerNumsSum);

        }
        return res.ToArray();
    }
}