public class Solution {
    public int MinSetSize(int[] arr) {
        
        var freq = arr
            .GroupBy(x => x)
            .Select(x => (Number: x.Key, Count: x.Count()))
            .OrderByDescending(x => x.Count)
            .ToList();

        var i = 0;
        var count = 0;
        var half = arr.Length / 2;
        while (half > 0) {
            half -= freq[i++].Count;
            count++;
        }

        return count;
    }
}