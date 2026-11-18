public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var counts = new Dictionary<int, int>();

        foreach (int num in nums) {
            counts.TryGetValue(num, out int cant);
            counts[num] = cant + 1;
        }

        return counts
            .OrderByDescending(p => p.Value)
            .Take(k)
            .Select(p => p.Key)
            .ToArray();
    }
}
