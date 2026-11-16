public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length -1;
        while (left<right){
            int sum = numbers[left] + numbers[right];
            if (sum == target) {
                return [left+1, right+1];
            }
            if (sum<target) left++;
            else right--;
        }
        return [];
        // for(int i =0; i<numbers.Length; i++)
        // {
        //     for(int j =i+1; j<numbers.Length; j++)
        //     {
        //         if(i<j){
        //             if(numbers[i]+numbers[j]==target){
        //                 return [i+1,j+1];
        //             }
        //         }
        //     }
        // }
        // return [];
    }
}
