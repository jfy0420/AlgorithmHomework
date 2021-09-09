using System.Collections.Generic;
using System;

namespace algorithmHomework{
/*
53. 最大子序和
*/
    public class LeetCode53{
        public int MaxSubArray(int[] nums) {
            int[] dp=nums;

            for(int i=1;i<nums.Length;i++){
                dp[i]=Math.Max(nums[i],nums[i]+dp[i-1]);
            }
            Array.Sort(dp);
            return dp[nums.Length-1];
        }
        public int MaxSubArray2(int[] nums) {
            int MaxRes=nums[0];
            int pre=0;

            for(int i=1;i<nums.Length;i++){
                pre=Math.Max(nums[i],nums[i]+pre);
                MaxRes=Math.Max(pre, MaxRes);
            }
            
            return MaxRes;
        }
    }

    
}