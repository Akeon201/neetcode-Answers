public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxConcsecNum = 0;
        int count = 0;
        int length = nums.Length;
        for (int i = 0; i < length; i += 1){
            if (nums[i] == 1)
                count++;
            else {
                maxConcsecNum = Math.Max(maxConcsecNum, count);
                count = 0;
            }
        }
        return Math.Max(maxConcsecNum, count);
    }
}