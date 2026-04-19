public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxConcsecNum = 0;
        int count = 0;
        foreach (var entry in nums){
            if (entry == 1){
                count+=1;
            }
            else {
                if(count > maxConcsecNum){
                    maxConcsecNum = count;
                }
                count = 0;
            }
        }
        if(count > maxConcsecNum){
            maxConcsecNum = count;
        }
        return maxConcsecNum;
    }
}