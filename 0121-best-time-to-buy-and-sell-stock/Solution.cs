public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int best = 0;
        for (int i = 1; i < prices.Length; i++) {
            if (prices[i] < minPrice) minPrice = prices[i];
            best = Math.Max(best, prices[i] - minPrice);
        }
        return best;
    }
}
