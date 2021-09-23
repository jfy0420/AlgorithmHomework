using System.Collections.Generic;
using System;

namespace algorithmHomework{
/*
213. 打家劫舍 II
*/
    public class LeetCode213{
        public int Rob(int[] nums) {
            
            int length=nums.Length;
            if(length==1)
                return nums[0];
            else if(length==2)
                return Math.Max(nums[0], nums[1]);

            return Math.Max(RobSub(nums,0,length-2),RobSub(nums,1, length-1));
        }

        private int RobSub(int[] nums, int start, int end)
        {
            int first=nums[start], second=Math.Max(nums[start],nums[start+1]);
            for(int i=start+2;i<=end;i++){
                int temp=second;
                second=Math.Max(nums[i]+first, second);
                first=temp;
            }

            return second;
        }
    }
}