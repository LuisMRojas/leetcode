public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> elementCount = new Dictionary<int, int>();


        foreach(int i in nums)
        {
            if(!elementCount.ContainsKey(i))
            {
                elementCount.Add(i,1);
            }
            else
            {
                elementCount[i] += 1;
            }
        }


        int[] results = new int[k];
        for(int i = 0; i < k; i++)
        {
            var maxValue = elementCount.MaxBy(x => x.Value);
            results[i] = maxValue.Key;
            elementCount.Remove(maxValue.Key);
        }

        return results;
    }
}
