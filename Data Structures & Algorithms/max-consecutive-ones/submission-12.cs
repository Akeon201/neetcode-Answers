public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxConcsecNum = 0;
        int count = 0;
        for (int i = 0; i < nums.Length; i += 1){
            if (nums[i] == 1){
                count++;
            } else {
                if (count > maxConcsecNum){
                    maxConcsecNum = count;
                }
                count = 0;
            }
        }
        if (count > maxConcsecNum)
            maxConcsecNum = count;
        return maxConcsecNum;
    }
}