public class Solution {
    public int MaxSubArray(int[] nums) {
        int current = nums[0];
        int best = nums[0];
        for (int i = 1; i < nums.Length; i++) {
            current = Math.Max(nums[i], current+nums[i]);
            best = Math.Max(best, current);
        }
        return best;
    }
}
