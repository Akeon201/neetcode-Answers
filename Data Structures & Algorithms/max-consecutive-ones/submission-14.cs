public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int n = nums.Length;
        int current = 0;
        int max=0;

        for (int i = 0; i<n; i++)
        {
            if (nums[i]==1)
            {
                current++;
            }
            else 
            {
                if (current > max)
                {
                    max = current;
                    
                }
                current = 0;
                
            }
        }

        if (current > max)
        {
            max = current;
        }
        return max;
    }
}